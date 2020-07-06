using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Orchestrator.Models
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
    }
}
