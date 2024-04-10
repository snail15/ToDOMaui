using ToDoAppMaui.Models;

namespace ToDoAppMaui.Repositories;

public class TodoItemRepository : ITodoItemRepository
{

    public event EventHandler<TodoItem> OnItemAdded;
    public event EventHandler<TodoItem> OnItemUpdated;
    
    public async Task<List<TodoItem>> GetItemsAsync()
    {
        return null;
    }
    public async Task AddItemAsync(TodoItem item)
    {
        
    }
    public async Task UpdateItemAsync(TodoItem item)
    {
        
    }
    public async Task AddOrUpdateItemAsync(TodoItem item)
    {
        if (item.Id == 0)
        {
            await AddItemAsync(item);
        }
        else
        {
            await UpdateItemAsync(item);
        }
    }
}
