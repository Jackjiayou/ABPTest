using Abp.Authorization;
using ABPCoreSpa.Authorization.Roles;
using ABPCoreSpa.Authorization.Users;

namespace ABPCoreSpa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
