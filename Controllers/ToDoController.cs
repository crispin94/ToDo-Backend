using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoAppBack.Data;
using ToDoAppBack.Models;

namespace ToDoAppBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ToDoController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDo>>> GetToDos()
        {
            return await _context.ToDos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDo>> GetToDo(int id)
        {
            var todo = await _context.ToDos.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }
            return todo;
        }

        [HttpPost]
        public async Task<ActionResult<ToDo>> CreateToDo(ToDo todo)
        {
            _context.ToDos.Add(todo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetToDo), new { id = todo.Id }, todo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateToDo(int id, [FromBody] ToDo todo)
        {
            if (id != todo.Id)
            {
                return BadRequest($"The ID in the URL ({id}) does not match the ID in the body ({todo.Id}).");
            }

            var existingToDo = await _context.ToDos.FindAsync(id);
            if (existingToDo == null)
            {
                return NotFound($"ToDo with ID {id} not found.");
            }
            existingToDo.TaskName = todo.TaskName;
            existingToDo.IsCompleted = todo.IsCompleted;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDo(int id)
        {
            var todo = await _context.ToDos.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }
            _context.ToDos.Remove(todo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool ToDoExists(int id)
        {
            return _context.ToDos.Any(e => e.Id == id);
        }
    }
}
