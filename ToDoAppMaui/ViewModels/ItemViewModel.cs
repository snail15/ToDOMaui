using ToDoAppMaui.Repositories;

namespace ToDoAppMaui.ViewModels;

public class ItemViewModel : ViewModel
{
    private readonly ITodoItemRepository _repository;
    public ItemViewModel(ITodoItemRepository repository)
    {
        _repository = repository;
    }
}
