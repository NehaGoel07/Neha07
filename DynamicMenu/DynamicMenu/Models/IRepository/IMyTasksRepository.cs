using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenu.Models.IRepository
{
    public interface IMyTasksRepository
    {
        IEnumerable<MyTasks> GetTasks();
        int Insert(MyTasks tasks,string user);
        IEnumerable<MyTasks> GetByUser(string userId);
        MyTasks GetById(int taskId);
        int Update(MyTasks tasks, string user);
        int Delete(int id);
    }
}
