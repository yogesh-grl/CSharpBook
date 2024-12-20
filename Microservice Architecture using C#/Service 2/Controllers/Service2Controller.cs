using Microsoft.AspNetCore.Mvc;

namespace Service_2.Controllers
{
    public class Service2Controller : Controller
    {
        [HttpGet("Service2")]
        public string Service2()
        {
            return "Service 2";
        }
    }
}
