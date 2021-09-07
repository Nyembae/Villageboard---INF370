using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Menu_Types
{
    public class MenuTypeDto : EntityDto<int>
    {
        [Required]
        public string Name { get; set; }
    }
}
