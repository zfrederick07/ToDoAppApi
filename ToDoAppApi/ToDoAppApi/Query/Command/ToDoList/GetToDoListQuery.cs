using System.Collections.Generic;
using MediatR;
using ToDoAppApi.Models;

namespace ToDoAppApi.Query.Command.ToDoList
{
    public class GetToDoListQuery: IRequest<List<ToDoItem>>
    {
        public GetToDoListQuery()
        {
        }
    }
}