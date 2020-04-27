using MediatR;
using ToDoAppApi.Models;

namespace ToDoAppApi.Query.Command.ToDoList
{
    public class GetToDoListItemByIdQuery: IRequest<ToDoItem>
    {
        public int Id { get; set; }

        public GetToDoListItemByIdQuery(int id)
        {
            Id = id;
        }
    }
}