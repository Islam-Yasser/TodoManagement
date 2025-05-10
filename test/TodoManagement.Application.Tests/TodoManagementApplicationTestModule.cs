using Volo.Abp.Modularity;

namespace TodoManagement;

[DependsOn(
    typeof(TodoManagementApplicationModule),
    typeof(TodoManagementDomainTestModule)
)]
public class TodoManagementApplicationTestModule : AbpModule
{

}
