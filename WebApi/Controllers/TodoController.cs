using Database;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class TodoController : ControllerBase
    {
        private Services.ITodo _todoService;

        public TodoController(Services.ITodo todoService) 
        {
            _todoService = todoService;
        }

        /// <summary>
        /// Создание
        /// </summary>
        [HttpPost("todo", Order = 1)]        
        public Domains.Todo Create([FromBody] Domains.Inctance inctance)
        {
            return _todoService.Create(inctance);
        }

        /// <summary>
        /// Чтение списка
        /// </summary>
        [HttpGet("todo", Order = 2)]
        public IEnumerable<Domains.Todo> Read()
        {
            return _todoService.Read();
        }

        /// <summary>
        /// Чтение единственной записи
        /// </summary>
        [HttpGet("todo/{id}", Order = 3)]
        public Domains.Todo Read(Guid id)
        {
            return _todoService.Read(id);
        }

        /// <summary>
        /// Обновление
        /// </summary>
        [HttpPut("todo/{id}", Order = 4)]
        public Domains.Todo Update(Guid id, [FromBody] Domains.Inctance todo)
        {
            return _todoService.Update(id, todo);
        }

        /// <summary>
        /// Удаление
        /// </summary>
        [HttpDelete("todo/{id}", Order = 5)]
        [SwaggerOperation(Summary = "Удаление задачи")]
        public bool Delete(Guid id)
        {
            return _todoService.Delete(id);
        }
    }
}
