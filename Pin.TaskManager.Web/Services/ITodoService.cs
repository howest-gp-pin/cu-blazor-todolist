using Pin.TaskManager.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pin.TaskManager.Web.Services
{
    public interface ITodoService
    {
        IEnumerable<TodoItem> GetAll();

        Task<IEnumerable<TodoItem>> GetAllAsync();

        TodoItem GetById(Guid id);

        Task<TodoItem> GetByIdAsync(Guid id);

        bool Update(TodoItem item);

        Task<bool> UpdateAsync(TodoItem item);

        Task<bool> DeleteAsync(Guid id);
    }
}
