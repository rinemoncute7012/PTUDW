using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class PTB1ACController : Controller
    {
        public ActionResult PTB1AC()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PTB1AC(double a, double b)
        {
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