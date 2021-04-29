using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service2.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Service2Controller : ControllerBase
    {
        private static readonly string[] FakeResponse = new[]
        {
            "Service2", "Service2", "Service2", "Service2"
        };

        private readonly ILogger<Service2Controller> _logger;

        public Service2Controller(ILogger<Service2Controller> logger)
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
