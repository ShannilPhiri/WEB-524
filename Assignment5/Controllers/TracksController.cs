using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment5.Models;

namespace Assignment5.Controllers
{
    public class TracksController : Controller
    {
        private Manager m = new Manager();
        // GET: Tracks
        public ActionResult Index()
        {
            var obj = m.TrackGetAll();
            return View(obj);
        }

        // GET: Tracks/Details/5
        public ActionResult Details(int? id)
        {
            var obj = m.TrackGetByIdWithDetail(id.GetValueOrDefault());
            if(obj == null)
            {
                return HttpNotFound();
            }
            else
            {
             return View(obj);
            }
            
        }

        // GET: Tracks/Create
        public ActionResult Create()
        {
            var obj = new TrackAddFormViewModel();
            obj.AlbumList = new SelectList(m.AlbumGetAll(), "AlbumId", "Title");
            obj.MediaTypeList = new SelectList(m.MediaTypeGetAll(), "MediaTypeId", "Name");
            return View(obj);
        }

        // POST: Tracks/Create
        [HttpPost]
        public ActionResult Create(TrackAddFormViewModel model)
        {
            TrackBaseViewModel newItem = null;
            newItem = m.TrackAddNewData(model);
            if (!ModelState.IsValid)
            {
                return View(model);
                    // return RedirectToAction("Create");
            }
            else
            {
                return RedirectToAction("Details");
            }
            //return RedirectToAction("Details");
        }

        // GET: Tracks/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tracks/Edit/5
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

        // GET: Tracks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tracks/Delete/5
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
