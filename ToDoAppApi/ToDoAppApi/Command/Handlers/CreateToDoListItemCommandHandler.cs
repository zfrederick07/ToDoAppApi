using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoAppApi.Command.Command;
using ToDoAppApi.Repository.Interface;

namespace ToDoAppApi.Command.Handlers
{
    public class CreateToDoListItemCommandHandler : IRequestHandler<CreateToDoListItemCommand, bool>
    {
        private IToDoItemsRepository Repository;

        public CreateToDoListItemCommandHandler(IToDoItemsRepository repository)
        {
            Repository = repository;
        }

        public async Task<bool> Handle(CreateToDoListItemCommand request, CancellationToken cancellationToken)
        {
            var id = Repository.GetAllList().Count + 1;
            request.ToDoItem.Id = id;
            
            Repository.CreateToDoItem(request.ToDoItem);
            return true;
        }
    }
}