using Abp.Authorization;
using TestEmbeddedResources.Authorization.Roles;
using TestEmbeddedResources.Authorization.Users;

namespace TestEmbeddedResources.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
