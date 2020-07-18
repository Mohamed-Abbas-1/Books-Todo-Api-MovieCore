using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Interfaces
{
    public interface IToDoRepository
    {
        bool DoesItemExist(string id);
        IEnumerable<ToDoItem2> All { get; }
        ToDoItem2 Find(string id);
        void Insert(ToDoItem2 item);
        void Update(ToDoItem2 item);
        void Delete(string id);
    }
}
