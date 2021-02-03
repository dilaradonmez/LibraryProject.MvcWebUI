using LibraryProject.MvcWebUI.Models;
using LibraryProject.MvcWebUI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryProject.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        LibraryContext db = new LibraryContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUserVm appUserVM)
        {
            var user = db.AppUsers.Where(x => x.UserName == appUserVM.UserName && x.Password == appUserVM.Password).FirstOrDefault();
            if (user != null)
            {
                Session["login"] = user;
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }

        }
    }
}