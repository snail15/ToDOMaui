using CommunityToolkit.Mvvm.Input;
using ToDoAppMaui.Repositories;
using ToDoAppMaui.Views;

namespace ToDoAppMaui.ViewModels;

public partial class MainViewModel : ViewModel
{
    private readonly ITodoItemRepository _repository;
    private readonly IServiceProvider _services;
    public MainViewModel(ITodoItemRepository repository, IServiceProvider services)
    {
        _repository = repository;
        _services = services;
        Task.Run(async () => await LoadDataAsync());
    }
    
    private async Task LoadDataAsync()
    {
        
    }

    [RelayCommand]
    public async Task AddItemAsync() => await Navigation.PushAsync(_services.GetRequiredService<ItemView>());
}
