using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Interfaces
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();
    }
}
