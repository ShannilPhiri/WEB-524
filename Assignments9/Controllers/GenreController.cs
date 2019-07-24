using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignments9.Controllers
{
    public class GenreController : Controller
    {
        private Manager m = new Manager();
        // GET: Genre
        public ActionResult Index()
        {
            var obj = m.GenreGetAll();
            return View(obj);
        }

    }
}
