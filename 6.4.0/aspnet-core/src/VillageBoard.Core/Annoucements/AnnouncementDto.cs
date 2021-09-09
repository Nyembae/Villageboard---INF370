using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Annoucements
{
    public class AnnouncementDto : EntityDto<int>
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Decription { get; set; }

        [Required]
        public DateTime Date { get; set; }

        
    }
}
