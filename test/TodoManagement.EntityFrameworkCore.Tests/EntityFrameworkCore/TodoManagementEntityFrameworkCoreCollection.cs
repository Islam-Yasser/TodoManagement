using Xunit;

namespace TodoManagement.EntityFrameworkCore;

[CollectionDefinition(TodoManagementTestConsts.CollectionDefinitionName)]
public class TodoManagementEntityFrameworkCoreCollection : ICollectionFixture<TodoManagementEntityFrameworkCoreFixture>
{

}
