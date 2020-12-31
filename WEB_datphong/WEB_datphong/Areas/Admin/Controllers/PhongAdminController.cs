using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Controllers;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Areas.Admin.Controllers
{
    public class PhongAdminController : Controller
    {
        // GET: Admin/PhongAdmin
        public ActionResult Index()
        {
            var db = HotelOnlineClass.DanhSachPhong();
            return View(db);
        }

        // GET: Admin/PhongAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/PhongAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PhongAdmin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/PhongAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/PhongAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/PhongAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/PhongAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
