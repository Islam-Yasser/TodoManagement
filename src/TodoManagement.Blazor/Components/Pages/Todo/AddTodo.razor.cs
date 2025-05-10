using System;
using System.Threading.Tasks;
using TodoManagement.Todo;

namespace TodoManagement.Blazor.Components.Pages.Todo;

public partial class AddTodo
{
    public CreateUpdateTodoDto CreateUpdateTodoDto { get; set; } = new();

    private  void HandleDateChanging(DateTime Value)
    {
        CreateUpdateTodoDto.DueDate=Value;
    }

    private void Cancel() => Navigation.NavigateTo("/todos");

    private async Task Submit()
    {
        var result =await TodoAppService.CreateAsync(CreateUpdateTodoDto);
        if(result != null)
        {
            Navigation.NavigateTo("/todos");
        }
    }
}
