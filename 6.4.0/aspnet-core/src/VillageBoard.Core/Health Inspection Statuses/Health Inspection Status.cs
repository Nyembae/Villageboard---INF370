using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Health_Inspection_Statuses
{
    public class Health_Inspection_Status : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
