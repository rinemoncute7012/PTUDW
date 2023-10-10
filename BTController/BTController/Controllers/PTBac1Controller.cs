using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class PTBac1Controller : Controller
    {
        // GET: PTBac1
        public ActionResult UserRequest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserRequest(string i)
        {
            double a = double.Parse(Request["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(Request["b"]);
            if(a == 0)
            {
                if (b == 0)
                    ViewBag.KQ = "Vô số nghiệm";
                else
                    ViewBag.KQ = "Vô nghiệm";
            }
            else
            {
                ViewBag.KQ = -b / a;
            }
            return View();
        }
    }
}