using TodoManagement.Samples;
using Xunit;

namespace TodoManagement.EntityFrameworkCore.Domains;

[Collection(TodoManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TodoManagementEntityFrameworkCoreTestModule>
{

}
