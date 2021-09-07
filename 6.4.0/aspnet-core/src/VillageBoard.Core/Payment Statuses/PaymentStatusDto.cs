using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Payment_Statuses
{
    public class PaymentStatusDto : EntityDto<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        
    }
}
