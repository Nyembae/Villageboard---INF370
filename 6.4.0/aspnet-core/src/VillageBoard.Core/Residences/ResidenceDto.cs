using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Residences
{
  public class ResidenceDto : EntityDto<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(225)]
        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string Gender { get; set; }
    }
}
