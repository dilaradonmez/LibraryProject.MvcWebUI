using LibraryProject.MvcWebUI.Models;
using LibraryProject.MvcWebUI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryProject.MvcWebUI.Controllers
{
    public class AppUserController : Controller
    {
        LibraryContext db = new LibraryContext();
        // GET: AppUser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AppUser appUser)
        {
            if (ModelState.IsValid)
            {
                if (db.AppUsers.Any(x => x.Email == appUser.Email || x.UserName == appUser.UserName))
                {
                    TempData["error"] = "Bu kullanıcı zaten kayıtlı";
                    return View();
                }
                else
                {
                    db.AppUsers.Add(appUser);
                    db.SaveChanges();
                    return View();
                }

            }
            else
            {
                return View(appUser);
            }

        }
    }
}