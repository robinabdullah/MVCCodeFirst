using MVCCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirst.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Person p)
        {
            PersonDBContext db = new PersonDBContext();
            db.Persons.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult ListPerson()
        {

            return View(new PersonDBContext().Persons);
        }
    }
}