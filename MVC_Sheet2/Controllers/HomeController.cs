using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sheet2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        /*
        public ActionResult Loan()
        {
            return View();
        }

        public ActionResult Grades()
        {
            return View();
        }*/
    }
}