using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreSpa.Sessions.Dto;

namespace ABPCoreSpa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
