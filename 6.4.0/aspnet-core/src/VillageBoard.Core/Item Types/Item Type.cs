using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Item_Types
{
    public class Item_Type : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
