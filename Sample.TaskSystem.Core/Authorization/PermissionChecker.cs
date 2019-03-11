using Abp.Authorization;
using Sample.TaskSystem.Authorization.Roles;
using Sample.TaskSystem.MultiTenancy;
using Sample.TaskSystem.Users;

namespace Sample.TaskSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
