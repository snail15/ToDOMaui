using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ToDoAppMaui.Models;
using ToDoAppMaui.Repositories;
using ToDoAppMaui.Views;

namespace ToDoAppMaui.ViewModels;

public partial class MainViewModel : ViewModel
{
    private readonly ITodoItemRepository _repository;
    private readonly IServiceProvider _services;

    [ObservableProperty] private ObservableCollection<TodoItemViewModel> _items;
    public MainViewModel(ITodoItemRepository repository, IServiceProvider services)
    {
        _repository.OnItemAdded += (sender, item) => Items.Add(CreateTodoItemViewModel(item));
        _repository.OnItemUpdated += (sender, item) => Task.Run(async () => await LoadDataAsync());
        _repository = repository;
        _services = services;
        Task.Run(async () => await LoadDataAsync());
    }
    
    private async Task LoadDataAsync()
    {
        var items = await _repository.GetItemsAsync();
        var itemViewModels = items.Select(item => CreateTodoItemViewModel(item));
        Items = new ObservableCollection<TodoItemViewModel>(itemViewModels);
    }
    private TodoItemViewModel CreateTodoItemViewModel(TodoItem item)
    {
        var itemViewModel = new TodoItemViewModel(item);
        itemViewModel.ItemStatusChanged += ItemStatusChanged;
        return itemViewModel;
    }
    private void ItemStatusChanged(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    [RelayCommand]
    public async Task AddItemAsync() => await Navigation.PushAsync(_services.GetRequiredService<ItemView>());
}
