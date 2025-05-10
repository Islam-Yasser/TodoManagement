using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoManagement.Todo;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using TodoManagement.Entities;


namespace TodoManagement.Todos;

public class TodoAppService : CrudAppService<TodoManagement.Entities.Todo, TodoDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTodoDto>, ITodoAppService
{
    public TodoAppService(Volo.Abp.Domain.Repositories.IRepository<TodoManagement.Entities.Todo, Guid> repository) : base(repository)
    {
    }

}
