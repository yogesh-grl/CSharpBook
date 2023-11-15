using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WebAppSample.Models;

namespace WebAppSample.Controllers
{
    [Route("[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppSetting _applicationSetting;
        public AuthController(IOptions<AppSetting> _applicationSetting)
        {
            this._applicationSetting = _applicationSetting.Value;
        }

        private static List<Users> lsUsers = new List<Users>();

        [HttpPost("Register")]
        public IActionResult Register([FromBody] Register registerModel)
        {
            var user = new Users { UserName = registerModel.UserName };

            if (registerModel.Password == registerModel.ConfirmationPassword)
            {
                using (HMACSHA512? hmac = new HMACSHA512())
                {
                    user.PasswordSalt = hmac.Key;
                    user.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(registerModel.Password));
                }
                lsUsers.Add(user);
            }
            else
            {
                return BadRequest("Confirmation password should be identical");
            }
            return Ok(user);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] Login loginModel)
        {
            // Find the user
            Users userData = lsUsers.Find(x => x.UserName == loginModel.UserName);
            if (userData != null)
            {
                bool PwdMatched = CheckPassWord(loginModel.Password, userData);

                if (PwdMatched)
                {
                    var key = Encoding.ASCII.GetBytes(_applicationSetting.Secret);
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new[] { new Claim("id", userData.UserName) }),
                        Expires = DateTime.UtcNow.AddDays(7),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha512Signature)
                    };

                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var encryptedToken = tokenHandler.WriteToken(token);

                    return Ok(new { token = encryptedToken, userName = userData.UserName });
                }
                else
                {
                    return BadRequest("Invalid password");
                }
            }
            else
            {
                return BadRequest("No user found");
            }
        }

        public bool CheckPassWord(string pwd, Users user)
        {
            bool status = true;
            using (HMACSHA512? hmac = new HMACSHA512(user.PasswordSalt))
            {
                byte[] PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pwd));
                status = PasswordHash.SequenceEqual(user.PasswordHash);
                
            }
            return status;
        }
    }
}
