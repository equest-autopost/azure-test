using Abp.Authorization;
using azuretest.Authorization.Roles;
using azuretest.Authorization.Users;

namespace azuretest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
