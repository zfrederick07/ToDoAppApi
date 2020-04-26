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
        
        // GET api/values
        [HttpGet]
        public async Task<List<ToDoItem>> GetToDoList()
        {
            var query = new GetToDoListQuery();
            var result = await mediator.Send(query);

            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetToDoListItem(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void CreateToDoListItem([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPost("{id}")]
        public void UpdateToDoListItem(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteToDoListItem(int id)
        {
        }
    }
}