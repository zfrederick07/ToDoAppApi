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
            Repository.CreateToDoItem(request.ToDoItem);
            return true;
        }
    }
}