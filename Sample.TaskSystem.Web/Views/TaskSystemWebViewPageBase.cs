using Abp.Web.Mvc.Views;

namespace Sample.TaskSystem.Web.Views
{
    public abstract class TaskSystemWebViewPageBase : TaskSystemWebViewPageBase<dynamic>
    {

    }

    public abstract class TaskSystemWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TaskSystemWebViewPageBase()
        {
            LocalizationSourceName = TaskSystemConsts.LocalizationSourceName;
        }
    }
}