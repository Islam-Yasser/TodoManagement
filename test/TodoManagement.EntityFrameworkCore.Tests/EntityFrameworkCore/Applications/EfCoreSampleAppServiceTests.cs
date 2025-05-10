using TodoManagement.Samples;
using Xunit;

namespace TodoManagement.EntityFrameworkCore.Applications;

[Collection(TodoManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TodoManagementEntityFrameworkCoreTestModule>
{

}
