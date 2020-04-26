using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoAppApi.Models;
using ToDoAppApi.Query.Command.ToDoList;

namespace ToDoAppApi.Controllers
{
    [Route("toDoList")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IMediator mediator;

        public ToDoListController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        
        [HttpGet]
        public async Task<List<ToDoItem>> GetToDoList()
        {
            var query = new GetToDoListQuery();
            var result = await mediator.Send(query);

            return result;
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetToDoListItem(int id)
        {
            return "value";
        }

        [HttpPost]
        public void CreateToDoListItem([FromBody] string value)
        {
        }

        [HttpPost("{id}")]
        public void UpdateToDoListItem(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void DeleteToDoListItem(int id)
        {
        }
    }
}