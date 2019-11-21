using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using taskManager.Authorization.Roles;
using taskManager.Authorization.Users;
using taskManager.MultiTenancy;

namespace taskManager.EntityFrameworkCore
{
    public class taskManagerDbContext : AbpZeroDbContext<Tenant, Role, User, taskManagerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public taskManagerDbContext(DbContextOptions<taskManagerDbContext> options)
            : base(options)
        {
        }
    }
}
