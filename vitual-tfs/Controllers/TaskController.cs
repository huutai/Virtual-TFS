using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using VirtualTFS.BL;
using VirtualTFS.Core.Utility;
using VirtualTFS.DAL;
using VirtualTFS.DAL.Models;
using VirtualTFS.Models;
using System;

namespace VirtualTFS.Controllers
{
    public class TaskController : Controller
    {
        //
        // GET: /Task/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetViewModel()
        {
            TaskViewModel viewModel = new TaskViewModel();
            viewModel.Iterations = Singleton<IterationImpl>.Instance.GetListIteration().Select(x => new IterationModel(x)).ToList();
            viewModel.Users = Singleton<UserImpl>.Instance.GetListUsers().Select(x => new aspnet_UsersModel(x)).ToList();
            viewModel.States = Singleton<StatusTaskImpl>.Instance.GetListStates().Select(x => new StatusParameterModel(x)).ToList();
            List<Block> list = new List<Block>();
            list.Add(new Block { Id = 1, Name = "Block 1" });
            list.Add(new Block { Id = 2, Name = "Block 2" });
            viewModel.Blocks = list;
            viewModel.Areas = Singleton<AreaImpl>.Instance.GetListArea().Select(x=>new AreaModel(x)).ToList();
            List<Activity> listac = new List<Activity>();
            listac.Add(new Activity { Id = 1, Name = "Acc 1" });
            listac.Add(new Activity { Id = 2, Name = "Acc 2" });
            viewModel.Activities = listac;
            return Json(viewModel);
        }

        public bool CreateTask(TaskModel model)
        {
            model.Id = GuidUtils.NewSeqGuid();
            model.CreatedDate = DateTime.Now;
            model.ModifiedDate = DateTime.Now;
            model.Type = 1;
            TaskImpl a = new TaskImpl();
            a.Create(model);
            return true;
        }

        public string Hello()
        {
            return "Thanh ho";
        }

    }
}
