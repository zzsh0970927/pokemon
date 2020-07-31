using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult mis2000lab()
        {
            return View();
        }

        public ActionResult index1C()
        {
            return Redirect("https://yahoo.com.tw") ;
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Redirect("https://yahoo.com.tw");
            base.HandleUnknownAction(actionName);
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
    }
}