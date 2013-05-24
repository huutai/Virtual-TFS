using System.Collections.Generic;
using System.Web.Mvc;
using VirtualTFS.BL;
using VirtualTFS.Core.Utility;
using VirtualTFS.DAL;
using System.Linq;
using VirtualTFS.DAL.Models;
using System;

namespace VirtualTFS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetTaskList()
        {
            try
            {
                IList<TaskModel> tasks = Singleton<TaskImpl>.Instance.GetTaskList();
                return Json(new { Result = "OK", Records = tasks });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", Message = ex.Message });
            }
        }
    }
}
