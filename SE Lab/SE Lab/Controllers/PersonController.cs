using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SE_Lab.Models;
using Microsoft.AspNet;
using Microsoft.AspNet.Identity;

namespace SE_Lab.Controllers
{
    public class PersonController : Controller
    {
		// GET: Person
		[Authorize]
		public ActionResult Index()
        {
			PhoneBookDbEntities db = new PhoneBookDbEntities();
			List<Person> Viewlist = db.People.ToList();
			List<PersonViewModel> List = new List<PersonViewModel>();
			foreach (Person a in Viewlist)
			{
				PersonViewModel ab  = new PersonViewModel();
				ab.PersonId = a.PersonId;
				ab.FirstName = a.FirstName;
				ab.MiddleName = a.MiddleName;
				ab.LastName = a.LastName;
				ab.DateOfBirth = a.DateOfBirth;
				ab.HomeAddress = a.HomeAddress;
				ab.HomeCity = a.HomeCity;
				ab.FaceBookAccountId = a.FaceBookAccountId;
				ab.TwitterId = a.TwitterId;
				ab.EmailId = a.EmailId;

				List.Add(ab);
			}
			return View(List);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

		// GET: Person/Create
		[Authorize]
		public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
		[Authorize]
		public ActionResult Create(PersonViewModel collection)
        {
            try
            {
				
				// TODO: Add insert logic here
				PhoneBookDbEntities db = new PhoneBookDbEntities();
				Person ac = new Person();
				ac.PersonId = collection.PersonId;
			    ac.FirstName = collection.FirstName;
				ac.MiddleName = collection.MiddleName;
				ac.LastName = collection.LastName;
				ac.DateOfBirth = collection.DateOfBirth;
				ac.HomeAddress = collection.HomeAddress;
				ac.HomeCity = collection.HomeCity;
				ac.FaceBookAccountId = collection.FaceBookAccountId;
				ac.TwitterId = collection.TwitterId;
				ac.EmailId = collection.EmailId;
				ac.AddedBy = User.Identity.GetUserId();
				ac.AddedOn = DateTime.Now;
				ac.UpdateOn = DateTime.Now;
				db.People.Add(ac);
				db.SaveChanges();
				
            }
            catch(Exception ex)
            {
                return View();
            }
			return RedirectToAction("Index");
		}

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
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

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
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
