using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WorkloadTwo.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WorkloadTwoController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<SimulationSoftwareTwo>), (int)HttpStatusCode.OK)]
        public IActionResult ReturnHealthcheckStatusAsync()
        {
            var simulationSoftwareTwo = new SimulationSoftwareTwo()
            {
                SoftwareName = "TPT",
                Status = "Healthy"
            };

            return Ok(simulationSoftwareTwo);
        }
    }
}
