using Microsoft.Extensions.Localization;
using TodoManagement.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TodoManagement.Blazor;

[Dependency(ReplaceServices = true)]
public class TodoManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TodoManagementResource> _localizer;

    public TodoManagementBrandingProvider(IStringLocalizer<TodoManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
