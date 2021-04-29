using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Service1.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Service1Controller : ControllerBase
    {
        private static readonly string[] FakeResponse = new[]
        {
            "Service1", "Service1", "Service1", "Service1"
        };

        private readonly ILogger<Service1Controller> _logger;

        public Service1Controller(ILogger<Service1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return FakeResponse.ToList();
        }
    }
}
