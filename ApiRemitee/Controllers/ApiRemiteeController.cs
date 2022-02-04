using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRemitee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiRemiteeController : ControllerBase
    { 

        private readonly ILogger<ApiRemiteeController> _logger;

        public ApiRemiteeController(ILogger<ApiRemiteeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ApiRemitee> Get()
        {
           
        }
    }
}
