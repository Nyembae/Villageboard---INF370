using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Blocks
{
    public class BlockAppService : CrudAppService<Block, BlockDto>
    {
        public BlockAppService(IRepository<Block, int> repository) : base(repository)
        {
        }

    }
}
