using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment6.Models;
using AutoMapper;

namespace Assignment6.Controllers
{
    public class PlayListController : Controller
    {

        private Manager m = new Manager();
     
        // GET: PlayList
        public ActionResult Index()
        {
            var obj = m.PlaylistGetAll();
            return View(obj);
        }

        // GET: PlayList/Details/5
        public ActionResult Details(int id)
        {
            var obj = m.PlayListGetById(id);
            return View(obj);
        }

        // GET: PlayList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlayList/Create
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

        // GET: PlayList/Edit/5
        public ActionResult Edit(int ?id)
        {
          var obj = m.PlayListGetById(id.GetValueOrDefault());
            if (obj == null)
            {
                return HttpNotFound();
            }

            else
            {
                var form = Mapper.Map <PlayListEditTrackFormViewModel>(obj);
                var selectedValues = obj.Tracks.Select(jd => jd.TrackId);
                form.TrackList = new MultiSelectList(items: m.TrackGetAll(),
                                                     dataValueField: "TrackId", 
                                                     dataTextField: "NameShort", 
                                                     selectedValues: selectedValues);

                form.TracksOnPlaylist = obj.Tracks.OrderBy(ln => ln.Name);

                return View(form);

            }
        }

        // POST: PlayList/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PlayListEditTrackViewModel collection)
        {
            if (!ModelState.IsValid)
            {
            return RedirectToAction("edit", new { id = collection.Id });

            }
            if (id != collection.Id)
            {
                return RedirectToAction("index");
            }

            var editedItem = m.PlaylistEdit(collection);

            if (editedItem == null)
            {
                return RedirectToAction("edit", new { id = collection.Id });
            }

            else
            {
                return RedirectToAction("Details", new { id = collection.Id });
           }
        }

        // GET: PlayList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlayList/Delete/5
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
