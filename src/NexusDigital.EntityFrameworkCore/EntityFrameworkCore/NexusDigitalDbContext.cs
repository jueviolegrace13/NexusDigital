using Abp.Zero.EntityFrameworkCore;
using NexusDigital.Authorization.Roles;
using NexusDigital.Authorization.Users;
using NexusDigital.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace NexusDigital.EntityFrameworkCore;

public class NexusDigitalDbContext : AbpZeroDbContext<Tenant, Role, User, NexusDigitalDbContext>
{
    /* Define a DbSet for each entity of the application */

    public NexusDigitalDbContext(DbContextOptions<NexusDigitalDbContext> options)
        : base(options)
    {
    }
}
