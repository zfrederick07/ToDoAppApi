using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoAppApi.Command.Command;
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
        public async Task<ToDoItem> GetToDoListItem(int id)
        {
            var query = new GetToDoListItemByIdQuery(id);
            var result = await mediator.Send(query);

            return result;
        }

        [HttpPost("create")]
        public async Task<bool> CreateToDoListItem([FromBody] ToDoItem item)
        {
            var command = new CreateToDoListItemCommand(item);
            var result = await mediator.Send(command);

            return result;
        }

        [HttpPost("update")]
        public async Task<bool> UpdateToDoListItem([FromBody] ToDoItem item)
        {
            var command = new UpdateToDoListItemCommand(item);
            var result = await mediator.Send(command);

            return result;
        }

        [HttpDelete("delete/{id}")]
        public async Task<bool> DeleteToDoListItem(int id)
        {
            var command = new DeleteToDoListItemCommand(id);
            var result = await mediator.Send(command);

            return result;
        }
    }
}