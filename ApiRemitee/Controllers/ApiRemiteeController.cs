using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ApiRemitee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiRemiteeController : ControllerBase
    {

        private readonly ILogger<ApiRemiteeController> _logger;
        private readonly DbContext _dbContext;


        public ApiRemiteeController(ILogger<ApiRemiteeController> logger, DbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost]
        public MonedaDeCambio PostMontoResultante(MonedaDeCambio monto, Fee fee, MonedaDeCambio montoResultante)
        {
            montoResultante.MontoResultante = monto.Monto * fee._Fee;
            return montoResultante;
        }
    }
}
