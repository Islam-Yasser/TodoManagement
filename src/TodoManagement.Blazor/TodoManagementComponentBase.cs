using TodoManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace TodoManagement.Blazor;

public abstract class TodoManagementComponentBase : AbpComponentBase
{
    protected TodoManagementComponentBase()
    {
        LocalizationResource = typeof(TodoManagementResource);
    }
}
