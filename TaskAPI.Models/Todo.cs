using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Models
{
    public enum TodoStatus
    {
        New,
        Inprogress,
        Completed
    }
    public class Todo
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public TodoStatus Status { get; set; }
    }
}
