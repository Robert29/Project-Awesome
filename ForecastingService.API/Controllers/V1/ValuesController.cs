using ForecastingService.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForecastingService.API.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValuesController : BaseController
    {
        public ValuesController(IOptions<ServiceConfiguration> configuration) : base(configuration)
        {
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Va fi", "un proiect", "LEGENDAR" };
        }
    }
}
