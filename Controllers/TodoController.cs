using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoApp.Services.TodoService _todoService;

        public TodoController(TodoApp.Services.TodoService todoService)
        {
            _todoService = todoService;
        }



        // Create todo
        [HttpPost(Name = "CreateTodo")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public JsonResult Create([FromBody] Todo todo)
        {
            var result = _todoService.Create(todo);
            if (result == null)
            {
                return new JsonResult(BadRequest());
            }

            return new JsonResult(Ok(todo)) { StatusCode = 201 };
        }


        // Get all todos
        [HttpGet(Name = "GetTodo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public JsonResult Get()
        {
            var result = _todoService.GetAllTodos();
            return new JsonResult(Ok(result));
        }


        // Get todo by id
        [HttpGet("{id}", Name = "GetTodoById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public JsonResult Get(int id)
        {
            var result = _todoService.GetTodoById(id);
            if (result == null)
                return new JsonResult(NotFound());
            return new JsonResult(Ok(result));
        }


        // Update todo
        [HttpPut("{id}", Name = "UpdateTodo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public JsonResult Update(int id, [FromBody] Todo todo)
        {
            var result = _todoService.Update(todo);
            if (result == null)
                return new JsonResult(BadRequest());
            return new JsonResult(Ok(result));
        }


        // Delete todo
        [HttpDelete("{id}", Name = "DeleteTodo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public JsonResult Delete(int id)
        {
            var result = _todoService.Delete(id);
            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok());
        }
    }

}