using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orchestrator.Models
{
    public class Simulation : BaseEntity
    {
        public DateTime Date { get; set; }

        public string Name { get; set; }
    }
}
