using LibraryProject.MvcWebUI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryProject.MvcWebUI.Controllers
{
    [AuthFilter]
    public class DashBoardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}