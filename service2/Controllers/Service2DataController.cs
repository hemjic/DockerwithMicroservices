using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace service2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Service2DataController : ControllerBase
    {
        private readonly ILogger<Service2DataController> _logger;

        public Service2DataController(ILogger<Service2DataController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet("service2/{id}")]
        public string service2(int id)
        {
            Console.WriteLine("Methode from Service2");
            return "Method from service2 -value- " + id.ToString();
        }

        [HttpGet("test/{id}")]
        public string test(int id)
        {
            Console.WriteLine("Methode from Service2");
            return "Method from test -value- " + id.ToString();
        }
    }
}
