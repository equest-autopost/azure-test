using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using azuretest.Authorization.Roles;
using azuretest.Authorization.Users;
using azuretest.MultiTenancy;

namespace azuretest.EntityFrameworkCore
{
    public class azuretestDbContext : AbpZeroDbContext<Tenant, Role, User, azuretestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public azuretestDbContext(DbContextOptions<azuretestDbContext> options)
            : base(options)
        {
        }
    }
}
