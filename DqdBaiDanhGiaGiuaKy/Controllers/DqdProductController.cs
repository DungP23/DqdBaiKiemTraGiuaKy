using System;
using DqdBaiDanhGiaGiuaKy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DqdBaiDanhGiaGiuaKy.Controllers
{
    public class DqdProductController : Controller
    {
        private static List<DqdProduct> dqdProduct = new List<DqdProduct>()
        {
            new DqdProduct{Id=100, Name="DangQuangDung", Image="K22Cntt1", Quantity=19, Price=2004, isActive="Active"},
            new DqdProduct{Id=101, Name="NguyenKhanhPhuong",Image="K72Cntt1", Quantity=18, Price=2005, isActive="NonActive"}

        };
        // GET: DqdProduct
        public ActionResult Index()
        {
            return View(dqdProduct);
        }

        public ActionResult DqdCreate()
        {
            var dqdProduct = new DqdProduct();
            return View();
        }
        [HttpPost]
        public ActionResult DqdCreate(DqdProduct dqdProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(dqdProduct);
            }
            dqdProduct.Add(dqdProduct);
            return RedirectToAction("Index");
        }
    }
}