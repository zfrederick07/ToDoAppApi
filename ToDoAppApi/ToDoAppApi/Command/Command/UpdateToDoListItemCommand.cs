using MediatR;
using ToDoAppApi.Models;

namespace ToDoAppApi.Command.Command
{
    public class UpdateToDoListItemCommand : IRequest<bool>
    {
        public ToDoItem ToDoItem { get; private set; }

        public UpdateToDoListItemCommand(ToDoItem toDoItem)
        {
            ToDoItem = toDoItem;
        }
    }
}