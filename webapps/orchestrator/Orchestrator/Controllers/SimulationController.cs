using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orchestrator.Interfaces;
using Orchestrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orchestrator.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SimulationController : ControllerBase
    {
        private readonly ILogger<SimulationController> _logger;
        private IAsyncRepository<Simulation> _repository;

        public SimulationController(ILogger<SimulationController> logger, IAsyncRepository<Simulation> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(_repository.ListAllAsync());
        }

        [HttpPost]
        public IActionResult Post()
        {
            Simulation bareBonesCRUDItem = new Simulation()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString("n").Substring(0, 8),
                Date = DateTime.Now
            };
            return Ok(_repository.AddAsync(bareBonesCRUDItem));
        }
    }
}
