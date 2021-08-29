using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;
using TaskAPI.Services.Interfaces;

namespace TaskAPI.Services.Services
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext dbContext = new TodoDbContext();
        public List<Todo> AllTodos()
        {
            return dbContext.Todos.ToList();
        }
    }
}
