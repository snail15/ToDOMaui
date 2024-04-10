using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ToDoAppMaui.Models;
using ToDoAppMaui.Repositories;

namespace ToDoAppMaui.ViewModels;

public partial class ItemViewModel : ViewModel
{
    private readonly ITodoItemRepository _repository;
    [ObservableProperty] private TodoItem _item;
    public ItemViewModel(ITodoItemRepository repository)
    {
        _repository = repository;
        Item = new TodoItem()
        {
            Due = DateTime.Now.AddDays(1)
        };
    }

    [RelayCommand]
    public async Task SaveAsync()
    {
        await _repository.AddOrUpdateItemAsync(Item);
        await Navigation.PopAsync();
    }
}
