using Microsoft.AspNetCore.Http;
using System.Text;

namespace WebAppSample.Helper.Middleware.TaskMiddleware
{
    public class BasicAuthHandler
    {
        private readonly RequestDelegate _next;
        public BasicAuthHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (!httpContext.Request.Headers.ContainsKey("Authorization"))
            {
                httpContext.Response.StatusCode = 401;
                await httpContext.Response.WriteAsync("Unauthorized");
                return;
            }
            else
            {
                var header = httpContext.Request.Headers["Authorization"].ToString();
                var encodedCreds = header.Substring(6);
                var creds = Encoding.UTF8.GetString(Convert.FromBase64String(encodedCreds));
                string[] uiPwd = creds.Split(":");
                var uid = uiPwd[0];
                var password = uiPwd[1];

                if (Authenticate(uid, password))
                {
                    httpContext.Response.StatusCode = 401;
                    await httpContext.Response.WriteAsync("Unauthorized");
                    return;
                }
                else
                {
                    //await _next(httpContext);
                }
            }
            await _next(httpContext);
        }

        private bool Authenticate(string UserName, string Pwd)
        {
            if (UserName != "Yogesh" || Pwd != "Password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
