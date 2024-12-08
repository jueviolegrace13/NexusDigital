using Abp.Authorization;
using NexusDigital.Authorization.Roles;
using NexusDigital.Authorization.Users;

namespace NexusDigital.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
