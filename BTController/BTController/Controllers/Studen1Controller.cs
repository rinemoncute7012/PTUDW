using BTController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTController.Controllers
{
    public class Studen1Controller : Controller
    {
        // GET: Studen1
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase img, studen1 stu)
        {
            //Lấy thông tin từ input type=file có tên Avatar
            string postedFileName = System.IO.Path.GetFileName(img.FileName);
            //Lưu hình đại diện về Server
            var path = Server.MapPath("/images/" + postedFileName);
            img.SaveAs(path);
            string fSave = Server.MapPath("/App_Data/stu.txt");
            string[] stuInfo ={stu.ID, stu.Name, postedFileName};
            //Lưu các thông tix vào tập tin emp.txt
            System.IO.File.WriteAllLines(fSave, stuInfo);
            //Ghi nhận các thông tin đăng ký để hiện thị trên View Confirm
            ViewBag.ID = stuInfo[0];
            ViewBag.Name = stuInfo[1];
            ViewBag.img = "/images/" + stuInfo[2];
            return View("Confirm");
        }
        public ActionResult Confirm(studen1 stu)
        {
            return View();
        }
    }
}