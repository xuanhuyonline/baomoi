using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2001190568_LeXuanHuy_KTL1.Models;

namespace _2001190568_LeXuanHuy_KTL1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
         [HttpGet]
        public ActionResult Trangchu()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Dangky()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }

        public ActionResult Lienhe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dangky(User us)
        {
            if (ModelState.IsValid)
            {
                Session["us"] = new User() { Ten = us.Ten, Email = us.Email, GioiTinh = us.GioiTinh, NgheNghiep = us.NgheNghiep, PassWord = us.PassWord };
                return RedirectToAction("DangNhap", "Home");
            }
            else
                return View();
        }

        [HttpPost]
        public ActionResult DangNhap(User us)
        {
            if(us.Ten.ToString() == "yennh" && us.PassWord.ToString() == "123456789")
            {
                return RedirectToAction("TrangChu", "Home");
            }
            return View();
        }
       
        static List<Hoa> hoa = new List<Hoa>();
        static int sl = 0;
        [HttpPost]
        public ActionResult TrangChu( string txt_name, int txt_pri, string image)
        {
            Hoa b = new Hoa( txt_name, txt_pri, image);
            hoa.Add(b);
            sl++;
            if (sl < 8)
                return View();
            else
            {
                return RedirectToAction("SanPham", "Home");
            }
        }
        public ActionResult SanPham()
        {
            ViewBag.Hoa = new List<Hoa>();
            ViewBag.Hoa = hoa;
            return View();
        }

    }

}
