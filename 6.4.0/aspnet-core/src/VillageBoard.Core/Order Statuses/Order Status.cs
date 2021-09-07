﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Order_Statuses
{
    class Order_Status : Entity<int>
    {
        [Required]
        [MaxLength(225)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}