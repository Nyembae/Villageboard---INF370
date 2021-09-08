using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Meal_Types
{
    public class MealTypeDto : EntityDto<int>
    {
        [Required]
        public string Name { get; set; }
    }
}
