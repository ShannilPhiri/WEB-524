using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2.EntityModels;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class EmployeeController : Controller
    {

        //reference to a Manager
        private Manager m = new Manager();

        // GET: Employee
        public ActionResult Index()
        {
            var obj = m.EmployeeGetAll();

            return View(obj);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            //get collection of employee based on id
            var obj = m.EmployeeGetById(id);

            //if result is null return not found page
            if(obj == null)
            {
                return HttpNotFound();
            }
            else
            {
                //else return found object
           return View(obj);
            }
            
        }

        // GET: Employee/Create
        public ActionResult Create()
        {

            //obj created based on "add" view model
            var obj = new EmployeeAddViewModel();

            //object passed to view
            return View(obj);
        }

        // POST: Employee/Create
        //addviewmodel is always used as the parameter type Not FormControll
        [HttpPost]
        public ActionResult Create(EmployeeAddViewModel collection)
        {
            //first task is to always validate incoming data
            if (!ModelState.IsValid)
            {
                //if not valid view is returned with written data
                return View(collection);
            }

            else
            {
                // create new object by calling add function from manager.cs
                var obj = m.EmployeeAdd(collection);
                if (obj == null)
                {
                    return View(collection);

                }
                else
                {
                    return RedirectToAction("Details", new { id = obj.EmployeeId });
                }

            }
           
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
