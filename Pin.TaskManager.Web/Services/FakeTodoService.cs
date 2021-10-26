using Pin.TaskManager.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pin.TaskManager.Web.Services
{
    public class FakeTodoService : ITodoService
    {
        private static List<TodoItem> items = new List<TodoItem>
        {
            new TodoItem { Id = Guid.NewGuid(), Name = "Start my IMI project with Blazor", Progress = 0 },
            new TodoItem { Id = Guid.NewGuid(), Name = "Get started with my first Blazor components", Progress = 0.10 },
            new TodoItem { Id = Guid.NewGuid(), Name = "Bring my laptop", Progress = 1.00 }
        };

        public Task<bool> DeleteAsync(Guid id)
        {
            var itemToDelete = items.FirstOrDefault(todo => todo.Id == id);
            bool isRemoved = items.Remove(itemToDelete);
            return Task.FromResult(isRemoved);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return items;
        }

        public Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return Task.FromResult(GetAll());
        }

        public TodoItem GetById(Guid id)
        {
            return items.FirstOrDefault(e => e.Id == id);
        }

        public Task<TodoItem> GetByIdAsync(Guid id)
        {
            return Task.FromResult(GetById(id));
        }

        public bool Update(TodoItem item)
        {
            return true;
        }

        public Task<bool> UpdateAsync(TodoItem item)
        {
            return Task.FromResult(Update(item));
        }
    }
}
