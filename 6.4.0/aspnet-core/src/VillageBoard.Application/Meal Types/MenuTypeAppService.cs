using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Menu_Types
{
   public class MealTypeAppService : CrudAppService<Menu_Type, MenuTypeDto>
    {
        public MealTypeAppService(IRepository<Menu_Type, int> repository) : base(repository)
        {

        }
    }
}
