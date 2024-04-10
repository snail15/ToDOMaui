using ToDoAppMaui.Repositories;

namespace ToDoAppMaui.ViewModels;

public class MainViewModel : ViewModel
{
    private readonly ITodoItemRepository _repository;
    public MainViewModel(ITodoItemRepository repository)
    {
        _repository = repository;
        Task.Run(async () => await LoadDataAsync());
    }
    
    private async Task LoadDataAsync()
    {
        
    }
}
