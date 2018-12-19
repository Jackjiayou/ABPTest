using Abp.AutoMapper;
using ABPCoreSpa.Sessions.Dto;

namespace ABPCoreSpa.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}