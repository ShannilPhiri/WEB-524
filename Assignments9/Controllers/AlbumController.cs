using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignments9.Models;

namespace Assignments9.Controllers
{
    [Authorize]
    public class AlbumController : Controller
    {
        private Manager m = new Manager();
        // GET: Album
        public ActionResult Index()
        {
            var ob = m.LoadData();
            var obj = m.AlbumGetAll();
            return View(obj);
        }

        // GET: Album/Details/5
        public ActionResult Details(int? id)
        {
            var obj = m.AlbumGetByIdWithDetail(id.GetValueOrDefault());
            if(obj != null)
            {
                return View(obj);
            }
            return HttpNotFound();
        }

        // GET: Album/Create
        [Authorize(Roles = "Coordinator")]
        public ActionResult Create()
        {
            var form = new AlbumAddForm();
            form.GenreList = new SelectList(m.GenreGetAll(), "Name", "Name");
            form.ArtistList = new MultiSelectList(m.ArtistGetAll(), "Id", "Name");
            form.TrackList = new MultiSelectList(m.TrackGetAll(), "Id", "Name");
            return View(form);
        }

        // POST: Album/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(AlbumAdd form)
        {
           form.Coordinator = HttpContext.User.Identity.Name;
            if (ModelState.IsValid)
            {
                var obj = m.AlbumAdd(form);
                if (obj != null)
                {
                    return RedirectToAction("Details", new { id = obj.id });

                }
            }
            return Redirect("Index");
        }

       
    }
}
