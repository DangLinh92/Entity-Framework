using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyNV_CodeFirst.Models;

namespace QuanLyNV_CodeFirst.Controllers
{
    public class NhanVienController : Controller
    {
        QLNV_Context context = new QLNV_Context();
        // GET: NhanVien
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DanhSach()
        {
            var lstNhanVien = context.NhanViens;
            return View(lstNhanVien);
        }
    }
}