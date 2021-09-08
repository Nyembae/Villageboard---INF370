using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Item_Types
{
    public class ItemTypeDto : EntityDto<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
