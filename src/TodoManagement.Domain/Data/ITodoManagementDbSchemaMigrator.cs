using System.Threading.Tasks;

namespace TodoManagement.Data;

public interface ITodoManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
