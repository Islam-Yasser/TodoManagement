using TodoManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TodoManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TodoManagementEntityFrameworkCoreModule),
    typeof(TodoManagementApplicationContractsModule)
)]
public class TodoManagementDbMigratorModule : AbpModule
{
}
