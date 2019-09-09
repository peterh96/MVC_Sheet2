using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sheet2.Controllers
{
    public class LoanController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String init, String intr, String yrs)
        {
            try
            {
                float result = float.Parse(init);
                float interest = float.Parse(intr);
                float years = float.Parse(yrs);

                for (int x = 0; x < years; x++)
                {
                    result += result * (interest / 100);
                }

                ViewData["res"] = "Given "+years+" years, an investment of $"+float.Parse(init)+", and an annual rate of "+interest+"%, you will have $"+ Math.Round(result, 2)+".";
                return View();
            }
            catch (Exception e)
            {
                ViewData["res"] = "Error: something really unexpected went wrong!";
                return View();
            }

        }
    }
}