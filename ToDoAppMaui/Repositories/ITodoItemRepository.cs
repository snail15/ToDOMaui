using ToDoAppMaui.Models;

namespace ToDoAppMaui.Repositories;

public interface ITodoItemRepository
{
    event EventHandler<TodoItem> OnItemAdded;
    event EventHandler<TodoItem> OnItemUpdated;
    Task<List<TodoItem>> GetItemsAsync();
    Task AddItemAsync(TodoItem item);
    Task UpdateItemAsync(TodoItem item);
    Task AddOrUpdateItemAsync(TodoItem item);
}
