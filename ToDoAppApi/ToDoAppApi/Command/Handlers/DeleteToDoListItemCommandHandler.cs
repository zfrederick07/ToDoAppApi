using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoAppApi.Command.Command;
using ToDoAppApi.Repository.Interface;

namespace ToDoAppApi.Command.Handlers
{
    public class DeleteToDoListItemCommandHandler : IRequestHandler<DeleteToDoListItemCommand, bool>
    {
        private IToDoItemsRepository Repository;

        public DeleteToDoListItemCommandHandler(IToDoItemsRepository repository)
        {
            Repository = repository;
        }

        public async Task<bool> Handle(DeleteToDoListItemCommand request, CancellationToken cancellationToken)
        {
            var toDoItems = Repository.GetAllList();

            toDoItems.RemoveAll(a => a.Id == request.Id);

            Repository.DeleteToDoItem(toDoItems);

            return true;
        }
    }
}