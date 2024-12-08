using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Zero.Configuration;
using NexusDigital.Authorization.Roles;
using NexusDigital.Authorization.Users;
using NexusDigital.MultiTenancy;
using Microsoft.AspNetCore.Identity;

namespace NexusDigital.Authorization;

public class LogInManager : AbpLogInManager<Tenant, Role, User>
{
    public LogInManager(
        UserManager userManager,
        IMultiTenancyConfig multiTenancyConfig,
        IRepository<Tenant> tenantRepository,
        IUnitOfWorkManager unitOfWorkManager,
        ISettingManager settingManager,
        IRepository<UserLoginAttempt, long> userLoginAttemptRepository,
        IUserManagementConfig userManagementConfig,
        IIocResolver iocResolver,
        IPasswordHasher<User> passwordHasher,
        RoleManager roleManager,
        UserClaimsPrincipalFactory claimsPrincipalFactory)
        : base(
              userManager,
              multiTenancyConfig,
              tenantRepository,
              unitOfWorkManager,
              settingManager,
              userLoginAttemptRepository,
              userManagementConfig,
              iocResolver,
              passwordHasher,
              roleManager,
              claimsPrincipalFactory)
    {
    }
}
