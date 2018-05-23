using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScrumPenguins.Areas.Koala.Controllers
{
    public class TestController : Controller
    {
        // GET: Koala/Test
        public ActionResult Index()
        {
            return View();
        }

        // GET: Koala/Test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Koala/Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Koala/Test/Create
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

        // GET: Koala/Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Koala/Test/Edit/5
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

        // GET: Koala/Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Koala/Test/Delete/5
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
