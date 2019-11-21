using Abp.Authorization;
using taskManager.Authorization.Roles;
using taskManager.Authorization.Users;

namespace taskManager.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
