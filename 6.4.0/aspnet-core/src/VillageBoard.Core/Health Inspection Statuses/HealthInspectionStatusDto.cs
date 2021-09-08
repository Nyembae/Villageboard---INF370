using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Health_Inspection_Statuses
{
    public class HealthInspectionStatusDto : EntityDto<int>
    {
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
