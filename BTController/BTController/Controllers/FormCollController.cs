using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class FormCollController : Controller
    {
        public ActionResult FormColl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormColl(FormCollection f)
        {
            double a = double.Parse(f["a"]);
            double b = double.Parse(f["b"]);

            if (a == 0)
            {
                ViewBag.KQ = "Không phải là phương trình bậc nhất.";
            }
            else
            {
                double result = -b / a;
                ViewBag.KQ = "Nghiệm của phương trình là: " + result;
            }

            return View();
        }
    }

}