using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Interfaces;

namespace TaskAPI.Services.Services
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Description = "Description 01",
                Titel = "Titel 01",
                Created = System.DateTime.Now,
                Due = System.DateTime.Now.AddDays(4),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Description = "Description 02",
                Titel = "Titel 02",
                Created = System.DateTime.Now,
                Due = System.DateTime.Now.AddDays(4),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Description = "Description 03",
                Titel = "Titel 03",
                Created = System.DateTime.Now,
                Due = System.DateTime.Now.AddDays(4),
                Status = TodoStatus.New
            };
            todos.Add(todo3);

            return todos;
        }
    }
}
