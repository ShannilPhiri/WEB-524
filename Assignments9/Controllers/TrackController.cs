using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignments9.Models;
using AutoMapper;


namespace Assignments9.Controllers
{
    [Authorize]
    public class TrackController : Controller
    {
        private Manager m = new Manager();
        // GET: Track
        public ActionResult Index()
        {
            var obj = m.TrackGetAll();
            return View(obj);
        }

        // GET: Track/Details/5
        public ActionResult Details(int? id)
        {
            var obj = m.TrackGetByIdWithDetail(id.GetValueOrDefault());
            if(obj != null)
            {
                return View(obj);
            }
            return HttpNotFound();
        }

        // GET: Track/Create
        [Authorize(Roles = "Clerk")]
        public ActionResult Create()
        {
            var form = new TrackAddForm();
            form.GenreList = new SelectList(m.GenreGetAll(), "Name", "Name");
            form.AlbumList = new MultiSelectList(m.AlbumGetAll(), "Id", "Name");
            return View(form);
           
        }

        // POST: Track/Create
        [HttpPost]
        public ActionResult Create(TrackAdd form)
        {
            form.Clerk = HttpContext.User.Identity.Name;
            if (ModelState.IsValid)
            {
                var obj = m.TrackAdd(form);
                if (obj != null)
                {
                    return RedirectToAction("Details", new { id = obj.Id });

                }
            }
            return Redirect("Index");
        
    }

        // GET: Track/Edit/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                var track = m.TrackGetByIdWithDetail(id.GetValueOrDefault());
                if (track != null)
                    return View(Mapper.Map<TrackBase, TrackEditForm>(track));
            }
            return HttpNotFound();

        }

        // POST: Track/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id,TrackEdit form)
        {
            if (id != null && form.SampleAudio != null)
            {
                try
                {
                    var edited = m.TrackEdit(form);
                    if (edited) return RedirectToAction("Details", new { id = id.GetValueOrDefault() });
                }
                catch
                {
                    return View();
                }
            }
            return RedirectToAction("Index");
        }

       
    }
}
