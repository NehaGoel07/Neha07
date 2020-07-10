using DynamicMenu.Models.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DynamicMenu.Models.Repository
{
    public class MyTasksRepository : IMyTasksRepository
    {
        private readonly ApplicationContext context;

        public MyTasksRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public int Delete(int id)
        {
            var del = context.Database.ExecuteSqlRaw("exec Delete_Task {0}", id);
            return context.SaveChanges();
        }

        public MyTasks GetById(int taskId)
        {
            var result = context.MyTasks.FromSqlRaw("exec Get_Tasks_ById {0}", taskId).AsEnumerable().FirstOrDefault();
            return result;
        }

        public IEnumerable<MyTasks> GetByUser(string userId)
        {
            var result = context.MyTasks.FromSqlRaw("exec Get_Tasks_ByRole {0}", userId).ToList();
            return result;
        }

        public IEnumerable<MyTasks> GetTasks()
        {
            var result = context.MyTasks.FromSqlRaw("exec Get_Tasks").ToList();
            return result;
        }

        public int Insert(MyTasks tasks,string user)
        {
            _ = context.Database.ExecuteSqlRaw("exec Add_Task  {0},{1},{2},{3},{4},{5},{6},{7}",
                tasks.TaskName
                ,tasks.TaskDesc
                ,tasks.TaskDate
                ,tasks.CreatedOn
                ,tasks.Priority
                ,tasks.IsCompleted
                ,tasks.IsDeleted
                ,user);
            return context.SaveChanges();
        }

        public int Update(MyTasks tasks, string user)
        {
            _=context.Database.ExecuteSqlRaw("exec Update_Task {0},{1},{2},{3},{4},{5},{6},{7},{8}",
                  tasks.TaskId
                , tasks.TaskName
                , tasks.TaskDesc
                , tasks.TaskDate
                , tasks.CreatedOn
                , tasks.Priority
                , tasks.IsCompleted
                , tasks.IsDeleted
                , user
                );
            return context.SaveChanges();
        }
    }
}
