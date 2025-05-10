using TodoManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TodoManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TodoManagementController : AbpControllerBase
{
    protected TodoManagementController()
    {
        LocalizationResource = typeof(TodoManagementResource);
    }
}
