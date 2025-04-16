
namespace ToDoAppBack.Models
{
    using System;
    public class ToDo
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }

        public ToDo()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
