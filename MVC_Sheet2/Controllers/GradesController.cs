using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sheet2.Controllers
{
    public class GradesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            try
            {
                double grade_1 = double.Parse(form["g1"]);
                double grade_2 = double.Parse(form["g2"]);
                double grade_3 = double.Parse(form["g3"]);

                double avg = (grade_1 + grade_2 + grade_3) / 3;
                String result = "";

                String grade_color = "blue";

                if (avg == 100)
                {
                    result = "A+ PERFECT!!!";
                    grade_color = "green";
                }
                else if (avg > 89 && avg < 100)
                {
                    result = "GRADE: A NUMERIC GRADE: " + avg;
                    grade_color = "green";
                }
                else if (avg > 79 && avg < 89)
                {
                    result = "GRADE: B NUMERIC GRADE: " + avg;
                    grade_color = "green";
                }
                else if (avg > 69 && avg < 79)
                {
                    result = "GRADE: C NUMERIC GRADE: " + avg;
                    grade_color = "yellow";
                }
                else if (avg > 59 && avg < 69)
                {
                    result = "GRADE: C NUMERIC GRADE: " + avg;
                    grade_color = "red";
                }
                else if (avg < 60 && avg > 0)
                {
                    result = "GRADE: F NUMERIC GRADE: " + avg;
                    grade_color = "red";
                }
                else
                {
                    result = "ERROR";
                }
                ViewData["res"] = result;
                ViewData["color"] = grade_color;
                return View();
            }
            catch (Exception e)
            {
                ViewData["res"] = "something seriously went wrong!";
                return View();
            }
        }
    }
}