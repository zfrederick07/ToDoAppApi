using MediatR;
using ToDoAppApi.Models;

namespace ToDoAppApi.Command.Command
{
    public class CreateToDoListItemCommand : IRequest<bool>
    {
        public ToDoItem ToDoItem { get; private set; }

        public CreateToDoListItemCommand(ToDoItem toDoItem)
        {
            ToDoItem = toDoItem;
        }
    }
}