using Volo.Abp.Modularity;

namespace TodoManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class TodoManagementDomainTestBase<TStartupModule> : TodoManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
