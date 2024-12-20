using Microsoft.AspNetCore.Mvc;

namespace Service_1.Controllers
{
    public class Service1Controller : Controller
    {
        [HttpGet("Service1")]
        public string Service1()
        {
            return "Service 1";
        }
    }
}
