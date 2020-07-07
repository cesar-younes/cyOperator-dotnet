using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WorkloadOne.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WorkloadOneController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<SimulationSoftwareOne>), (int)HttpStatusCode.OK)]
        public IActionResult ReturnHealthcheckStatusAsync()
        {
            var simulationSoftwareOne = new SimulationSoftwareOne()
            {
                SoftwareName = "VTD",
                Status = "Healthy"
            };

            return Ok(simulationSoftwareOne);
        }
    }
}
