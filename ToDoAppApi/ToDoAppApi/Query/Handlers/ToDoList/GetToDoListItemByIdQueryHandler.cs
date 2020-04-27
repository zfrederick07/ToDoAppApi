using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoAppApi.Models;
using ToDoAppApi.Query.Command.ToDoList;
using ToDoAppApi.Repository.Interface;

namespace ToDoAppApi.Query.Handlers.ToDoList
{
    public class GetToDoListItemByIdQueryHandler: IRequestHandler<GetToDoListItemByIdQuery, ToDoItem>
    {
        private readonly IToDoItemsRepository _repository;

        public GetToDoListItemByIdQueryHandler(IToDoItemsRepository repository)
        {
            _repository = repository;
        }

        public Task<ToDoItem> Handle(GetToDoListItemByIdQuery request, CancellationToken cancellationToken)
        {
            var toDoListItem = _repository.GetAllList().Single(x => x.Id == request.Id);

            return Task.FromResult(toDoListItem);
        }
    }
}