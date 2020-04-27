using System.Collections.Generic;
using ToDoAppApi.Models;

namespace ToDoAppApi.Repository.Interface
{
    public interface IToDoItemsRepository
    {
        List<ToDoItem> GetAllList();
        void DeleteToDoItem(List<ToDoItem> newToDoItems);
        void CreateToDoItem(ToDoItem newToDoItem);
        void UpdateToDoItem(List<ToDoItem> newToDoItems);
    }
}