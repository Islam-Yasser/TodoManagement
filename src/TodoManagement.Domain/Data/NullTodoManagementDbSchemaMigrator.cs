using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TodoManagement.Data;

/* This is used if database provider does't define
 * ITodoManagementDbSchemaMigrator implementation.
 */
public class NullTodoManagementDbSchemaMigrator : ITodoManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
