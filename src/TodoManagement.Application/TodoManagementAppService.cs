using TodoManagement.Localization;
using Volo.Abp.Application.Services;

namespace TodoManagement;

/* Inherit your application services from this class.
 */
public abstract class TodoManagementAppService : ApplicationService
{
    protected TodoManagementAppService()
    {
        LocalizationResource = typeof(TodoManagementResource);
    }
}
