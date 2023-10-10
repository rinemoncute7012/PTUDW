using System;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class PTB1Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculateByModel()
        {
            // Logic tính toán phương trình bậc 1 bằng Model
            return View();
        }

        public ActionResult CalculateByRequest()
        {
            // Logic tính toán phương trình bậc 1 bằng Request
            return View();
        }

        public ActionResult CalculateByArgument(double a, double b)
        {
            // Logic tính toán phương trình bậc 1 bằng Đối số
            ViewBag.Result = (b != 0) ? (-a / b).ToString() : "Không có nghiệm";
            return View();
        }

        public ActionResult CalculateByFormCollection(FormCollection form)
        {
            // Logic tính toán phương trình bậc 1 bằng Form Collection
            double a = Convert.ToDouble(form["a"]);
            double b = Convert.ToDouble(form["b"]);
            ViewBag.Result = (b != 0) ? (-a / b).ToString() : "Không có nghiệm";
            return View();
        }
    }
}
