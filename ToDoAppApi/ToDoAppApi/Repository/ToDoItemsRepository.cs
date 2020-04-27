using System.Collections.Generic;
using ToDoAppApi.Models;
using ToDoAppApi.Repository.Interface;

namespace ToDoAppApi.Repository
{
    public class ToDoItemsRepository : IToDoItemsRepository
    {
        private List<ToDoItem> ToDoItems = new List<ToDoItem>();

        public ToDoItemsRepository()
        {
        }
        
        public List<ToDoItem> GetAllList()
        {
            return ToDoItems;
        }

        public void DeleteToDoItem(List<ToDoItem> newToDoItems)
        {
            ToDoItems = newToDoItems;
        }

        public void CreateToDoItem(ToDoItem newToDoItem)
        {
            ToDoItems.Add(newToDoItem);
        }

        public void UpdateToDoItem(List<ToDoItem> newToDoItems)
        {
            ToDoItems = newToDoItems;
        }
    }
}