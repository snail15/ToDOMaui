using CommunityToolkit.Mvvm.ComponentModel;
using ToDoAppMaui.Models;

namespace ToDoAppMaui.ViewModels;

public partial class TodoItemViewModel : ViewModel
{
    [ObservableProperty] private TodoItem _item;
    public event EventHandler ItemStatusChanged;
    
    public TodoItemViewModel(TodoItem item)
    {
        Item = item;
    }
    
    public string StatusText => Item.Completed ? "Reactivate" : "Completed";
}
