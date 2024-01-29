using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace service1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Service1DataController : ControllerBase
    {
        private readonly ILogger<Service1DataController> _logger;

        public Service1DataController(ILogger<Service1DataController> logger)
        {
            _logger = logger;
        }

        [HttpGet("test-api")]
        public string Get()
        {
            return "this is service 1 method";
        }
        [HttpGet("test-service/{id}")]
        public string testservice(int id)
        {
            return "Method with int Parameter " + id.ToString();
        }
        [HttpGet("test-hemji/{name}")]
        public string testhemji(string name)
        {
            return "Method with string Parameter " + name.ToString();
        }
    }
}
