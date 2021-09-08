using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Years
{
    public class Year : Entity<int>
    {
        [Required]
        public DateTime Date { get; set; }

    }
}
