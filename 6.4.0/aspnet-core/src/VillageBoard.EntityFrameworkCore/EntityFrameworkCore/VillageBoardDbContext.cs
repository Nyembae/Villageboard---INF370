using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VillageBoard.Authorization.Roles;
using VillageBoard.Authorization.Users;
using VillageBoard.MultiTenancy;
using VillageBoard.Announcement_Types;

namespace VillageBoard.EntityFrameworkCore
{
    public class VillageBoardDbContext : AbpZeroDbContext<Tenant, Role, User, VillageBoardDbContext>
    {
        public DbSet<Announcement_Type> Announcement_Types { get; set; }
        
        public VillageBoardDbContext(DbContextOptions<VillageBoardDbContext> options)
            : base(options)
        {
        }
    }
}
