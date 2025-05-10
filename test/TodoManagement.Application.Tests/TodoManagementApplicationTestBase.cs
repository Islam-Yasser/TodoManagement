using Volo.Abp.Modularity;

namespace TodoManagement;

public abstract class TodoManagementApplicationTestBase<TStartupModule> : TodoManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
