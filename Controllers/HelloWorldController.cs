using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var appVersion = Environment.GetEnvironmentVariable("appVersion") ?? "not specified";
            return $"Helloo World!!   Version: {appVersion}";
        }
    }
}
