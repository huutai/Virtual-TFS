using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualTFS.DAL;
using VirtualTFS.DAL.Models;
using VirtualTFS.DAL.Repositories;

namespace VirtualTFS.BL
{
    public class TaskImpl
    {
        public IList<TaskModel> GetTaskList()
        {
            TaskRepository taskRepository = new TaskRepository();
            StatusParameterRepository statusParameterRepository = new StatusParameterRepository();
            aspnet_UsersRepository aspnetUserRes = new aspnet_UsersRepository();
            IList<TaskModel> list = (from x in taskRepository.GetAllTask()
                                     join y in statusParameterRepository.GetAllStatusParameter()
                                     on x.Status equals y.Id
                                     join z in aspnetUserRes.GetAllaspnet_Users()
                                     on x.AssignedTo equals z.UserId

                                     select new TaskModel(x) { StatusName = y.Name, UserName = z.UserName }).ToList();
            return list;
        }
        public void Create(TaskModel taskModel)
        {
            TaskRepository taskRepository = new TaskRepository();
            taskRepository.AddTask(taskModel.MapTask());
            taskRepository.Commit();
        }    
    }
}
