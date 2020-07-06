using Microsoft.EntityFrameworkCore;
using Orchestrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orchestrator.Storage
{
    public class SimulationContext : DbContext
    {
        public SimulationContext(DbContextOptions<SimulationContext> options) : base(options)
        {
        }

        public DbSet<Simulation> Simulations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
