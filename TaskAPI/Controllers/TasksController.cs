using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Services.Interfaces;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;
        public TasksController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTasks(int ? id)
        {
            var todos = _todoRepository.AllTodos();
            if(id is not null)
            {
                todos = todos.Where(x => x.Id == id).ToList();
            }
            return Ok(todos);
        }
        [HttpPost]
        public IActionResult CreateTask()
        {
            return Content("Susses");
        }
    }
}
