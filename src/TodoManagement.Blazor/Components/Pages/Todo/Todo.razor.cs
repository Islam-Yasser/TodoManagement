
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using TodoManagement.Todo;
using Volo.Abp.Application.Dtos;

namespace TodoManagement.Blazor.Components.Pages.Todo;

public partial class Todo
{
    private IEnumerable<TodoDto> tableData = new List<TodoDto>();
    private int currentPage = 1;
    private int totalPages = 1;
    private int pageSize = 10;

    protected override async Task OnInitializedAsync()
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        var input = new PagedAndSortedResultRequestDto
        {
            MaxResultCount = pageSize,
            SkipCount = currentPage * pageSize,
            Sorting = "Status"
        };
        var todosResult = await TodoAppService.GetListAsync(input);
        tableData = todosResult.Items;
        StateHasChanged();

    }

    private async Task ChangePage(int newPage)
    {
        currentPage += newPage;
        await LoadData();
    }

    private void HandleAddTodo()
    {
        Navigation.NavigateTo("/addtodo");
    }
}
