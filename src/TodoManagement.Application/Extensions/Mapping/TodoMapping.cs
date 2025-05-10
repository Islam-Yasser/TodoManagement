using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManagement.Todo;

namespace TodoManagement.Extensions.Mapping;

public static class TodoMapping
{
    public static void MapTodo(this TodoManagementApplicationAutoMapperProfile map)
    {
        map.CreateMap<CreateUpdateTodoDto,TodoDto>().ReverseMap();
        map.CreateMap<TodoManagement.Entities.Todo, TodoDto>().ReverseMap();
    }
}
