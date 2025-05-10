using Volo.Abp.Modularity;

namespace TodoManagement;

[DependsOn(
    typeof(TodoManagementDomainModule),
    typeof(TodoManagementTestBaseModule)
)]
public class TodoManagementDomainTestModule : AbpModule
{

}
