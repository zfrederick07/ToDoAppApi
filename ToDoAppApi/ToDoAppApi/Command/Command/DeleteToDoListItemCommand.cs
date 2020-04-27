using MediatR;

namespace ToDoAppApi.Command.Command
{
    public class DeleteToDoListItemCommand : IRequest<bool>
    {
        public int Id { get; private set; }

        public DeleteToDoListItemCommand(int id)
        {
            Id = id;
        }
    }
}