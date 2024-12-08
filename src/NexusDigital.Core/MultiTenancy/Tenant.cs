using Abp.MultiTenancy;
using NexusDigital.Authorization.Users;

namespace NexusDigital.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}
