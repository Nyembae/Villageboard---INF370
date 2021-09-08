using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Health_Inspection_Types
{
    public class Health_Inpsection_Type : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
