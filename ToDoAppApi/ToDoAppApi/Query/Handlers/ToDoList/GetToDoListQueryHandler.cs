using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ToDoAppApi.Models;
using ToDoAppApi.Query.Command.ToDoList;
using ToDoAppApi.Repository.Interface;

namespace ToDoAppApi.Query.Handlers.ToDoList
{
    public class GetToDoListQueryHandler : IRequestHandler<GetToDoListQuery, List<ToDoItem>>
    {
        private readonly IToDoItemsRepository _repository;

        public GetToDoListQueryHandler(IToDoItemsRepository repository)
        {
            _repository = repository;
        }

        public Task<List<ToDoItem>> Handle(GetToDoListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.GetAllList());
        }
    }
}