using Microsoft.AspNetCore.Mvc;

namespace ExampleDockerUbuntu.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello world, using docker in ubuntu 20.4";
        }
    }
}
