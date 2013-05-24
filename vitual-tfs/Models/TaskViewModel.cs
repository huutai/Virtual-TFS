using System.Collections.Generic;
using System.Web.Mvc;
using VirtualTFS.DAL.Models;

namespace VirtualTFS.Models
{
    public class TaskViewModel
    {
        public List<IterationModel> Iterations { get; set; }
        public List<aspnet_UsersModel> Users;
        public List<StatusParameterModel> States;
        public List<Block> Blocks;
        public List<Activity> Activities;
        public List<AreaModel> Areas;
        
    }

    public class Block
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}