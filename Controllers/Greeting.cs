using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICore.Service;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Greeting : ControllerBase
    {
        private readonly IGreetingService _service;
        //Initialization of DI
        public Greeting(IGreetingService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(new { Greeting = _service.GetGreeting() });

        [HttpGet("{name}")]
        public IActionResult Get(string name) => Ok(new { Greeting = _service.GetPersonalGreeting(name) });

        
    }
}
