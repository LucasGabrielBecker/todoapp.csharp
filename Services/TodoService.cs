using Microsoft.EntityFrameworkCore;
using TodoApp.Models;
using TodoApp.Data;

namespace TodoApp.Services
{
    public class TodoService
    {

        private readonly ApiContext _context;
        private readonly ILogger _logger;
        public TodoService(ApiContext context, ILogger<TodoService> logger)
        {
            _context = context;
            _logger = logger;
        }

        //Get one todo by id
        public Todo? GetTodoById(int id)
        {
            _logger.LogInformation("Getting todo by id");
            var todo = _context.Todos.Find(id);
            if (todo == null)
                return null;
            return todo;
        }

        //Get all todos
        public List<Todo> GetAllTodos()
        {
            _logger.LogInformation("Getting all todos");
            return _context.Todos.ToList();
        }


        //Create todo
        public Todo? Create(Todo todo)
        {
            _logger.LogInformation("Creating todo");

            if (todo == null)
            {
                return null;
            }

            _context.Todos.Add(todo);
            _context.SaveChanges();
            return todo;
        }


        //Update todo
        public Todo? Update(Todo todo)
        {
            _logger.LogInformation("Updating todo");

            if (todo == null)
            {
                return null;
            }

            _context.Todos.Update(todo);
            _context.SaveChanges();
            return todo;
        }

        //Delete todo
        public Todo? Delete(int id)
        {
            _logger.LogInformation("Deleting todo");

            var todo = _context.Todos.Find(id);
            if (todo == null)
                return null;

            _context.Todos.Remove(todo);
            _context.SaveChanges();
            return todo;
        }

    }



}