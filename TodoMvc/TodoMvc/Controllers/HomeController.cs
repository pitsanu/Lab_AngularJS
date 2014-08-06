using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoMvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            //JsonResult rtn = new JsonResult();
            //rtn.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            //rtn.Data = new object();            

            return Json(new {}, JsonRequestBehavior.AllowGet);
        }

    }
}
