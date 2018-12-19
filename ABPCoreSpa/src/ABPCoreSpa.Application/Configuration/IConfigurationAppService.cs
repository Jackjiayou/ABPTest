using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreSpa.Configuration.Dto;

namespace ABPCoreSpa.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}