using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoAppApi.Command.Command;
using ToDoAppApi.Repository.Interface;

namespace ToDoAppApi.Command.Handlers
{
    public class UpdateToDoListItemCommandHandler: IRequestHandler<UpdateToDoListItemCommand, bool>
    {
        private IToDoItemsRepository Repository;

        public UpdateToDoListItemCommandHandler(IToDoItemsRepository repository)
        {
            Repository = repository;
        }

        public async Task<bool> Handle(UpdateToDoListItemCommand request, CancellationToken cancellationToken)
        {
            var toDoItems = Repository.GetAllList();

            toDoItems.RemoveAll(a => a.Id == request.ToDoItem.Id);
            toDoItems.Add(request.ToDoItem);
            
            Repository.UpdateToDoItem(toDoItems);

            return true;
        }
    }
}