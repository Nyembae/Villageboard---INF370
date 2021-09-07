﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard
{
    public class Meal_Type : Entity<int>
    {
        [Required]
        public string Name { get; set; }
    }
}