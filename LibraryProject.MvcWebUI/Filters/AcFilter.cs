using LibraryProject.MvcWebUI.Models;
using LibraryProject.MvcWebUI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryProject.MvcWebUI.Filters
{
    public class AcFilter:FilterAttribute,IActionFilter
    {
        LibraryContext db = new LibraryContext();

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log log = new Log();
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.LogDate = DateTime.Now;
            log.UserName = "admin";
            db.Logs.Add(log);
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log log = new Log();
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.LogDate = DateTime.Now;
            log.UserName = "admin";
            db.Logs.Add(log);
            db.SaveChanges();
        }
    }
}