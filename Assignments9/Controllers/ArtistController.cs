using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignments9.Models;

namespace Assignments9.Controllers
{
    [Authorize]
    public class ArtistController : Controller
    {
        private Manager m = new Manager();
        // GET: Artist
        public ActionResult Index()
        {
            var obj = m.ArtistGetAll();
            return View(obj);
        }

        // GET: Artist/Details/5
        public ActionResult Details(int? id)
        {
            var obj = m.ArtistGetByIdWithDetail(id.GetValueOrDefault());
            if(obj != null)
            {
                return View(obj);
            }
            return HttpNotFound();
        }

        // GET: Artist/Create
        [Authorize(Roles = "Executive")]
        public ActionResult Create()
        {
            var obj = new ArtistAddForm();
            obj.GenreList = new SelectList(m.GenreGetAll(), "Name", "Name");
            return View(obj);
            
        }

        // POST: Artist/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(ArtistAdd form)
        {
            form.Executive = HttpContext.User.Identity.Name;

            if (ModelState.IsValid)
            {
                var obj = m.ArtistAdd(form);
                if (obj != null)
                {
                    return RedirectToAction("Details", new { id = obj.Id });

                }
            }
            return Redirect("Index");
        }

        // GET: Artist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



       

    
    }
}
