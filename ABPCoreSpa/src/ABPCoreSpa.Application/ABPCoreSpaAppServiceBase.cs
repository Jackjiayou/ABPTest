using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using ABPCoreSpa.Authorization.Users;
using ABPCoreSpa.MultiTenancy;
using ABPCoreSpa.Users;
using Microsoft.AspNet.Identity;

namespace ABPCoreSpa
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ABPCoreSpaAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected ABPCoreSpaAppServiceBase()
        {
            LocalizationSourceName = ABPCoreSpaConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}