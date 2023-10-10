using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class CalModels
    {
        public double a { get; set; }
        public double b { get; set; }
        public string pt { get; set; }
    }

    public class ModCalController : Controller
    {

        public ActionResult ModCal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ModCal(CalModels cal)
        {
            if (cal.pt == "linear") // Kiểm tra nếu là phương trình bậc nhất
            {
                if (cal.a == 0)
                {
                    ViewBag.KQ = "Không phải là phương trình bậc nhất.";
                }
                else
                {
                    double result = -cal.b / cal.a;
                    ViewBag.KQ = "Nghiệm của phương trình là: " + result;
                }
            }
            else
            {
                ViewBag.KQ = "Phép tính không được hỗ trợ.";
            }

            return View();
        }
    }

}