using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreSpa.Authorization.Accounts.Dto;

namespace ABPCoreSpa.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
