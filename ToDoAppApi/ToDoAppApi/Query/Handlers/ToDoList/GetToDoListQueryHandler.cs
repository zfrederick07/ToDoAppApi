using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoAppApi.Models;
using ToDoAppApi.Query.Command.ToDoList;

namespace ToDoAppApi.Query.Handlers.ToDoList
{
    public class GetToDoListQueryHandler : IRequestHandler<GetToDoListQuery, List<ToDoItem>>
    {
        public Task<List<ToDoItem>> Handle(GetToDoListQuery request, CancellationToken cancellationToken)
        {
            var toDoItem = new ToDoItem(1, "Test", "Test Description", true);
            var toDoItem2 = new ToDoItem(2, "Test2", "Test2 Description", false);

            var list = new List<ToDoItem>() {toDoItem, toDoItem2};
            return Task.FromResult(list);
        }
    }
}