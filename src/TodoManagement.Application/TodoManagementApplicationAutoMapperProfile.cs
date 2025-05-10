using AutoMapper;
using TodoManagement.Extensions.Mapping;

namespace TodoManagement;

public class TodoManagementApplicationAutoMapperProfile : Profile
{
    public TodoManagementApplicationAutoMapperProfile()
    {
        //Mapping todo entity and dtos
        this.MapTodo();
       
    }
}
