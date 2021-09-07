using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VillageBoard.Authorization.Roles;
using VillageBoard.Authorization.Users;
using VillageBoard.MultiTenancy;

namespace VillageBoard.EntityFrameworkCore
{
    public class VillageBoardDbContext : AbpZeroDbContext<Tenant, Role, User, VillageBoardDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VillageBoardDbContext(DbContextOptions<VillageBoardDbContext> options)
            : base(options)
        {
        }
    }
}
