using Abp.Web.Mvc.Views;

namespace ABPCoreSpa.Web.Views
{
    public abstract class ABPCoreSpaWebViewPageBase : ABPCoreSpaWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPCoreSpaWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPCoreSpaWebViewPageBase()
        {
            LocalizationSourceName = ABPCoreSpaConsts.LocalizationSourceName;
        }
    }
}