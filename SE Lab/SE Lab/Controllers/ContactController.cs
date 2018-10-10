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
    public class ContactController : Controller
    {
		// GET: Contact
		[Authorize]
		public ActionResult Index()
        {

			PhoneBookDbEntities db = new PhoneBookDbEntities();
			List<Contact> Viewlist = db.Contacts.ToList();
			List<ContactViewModel> List = new List<ContactViewModel>();
			foreach (Contact a in Viewlist)
			{
				ContactViewModel ab = new ContactViewModel();
				ab.ContactId = a.ContactId;
				ab.ContactNumber= a.ContactNumber;
				ab.Type = a.Type;
				ab.PersonId = a.PersonId;
				List.Add(ab);
			}
			return View(List);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

		// GET: Contact/Create
		[Authorize]
		public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
		[Authorize]
		public ActionResult Create(ContactViewModel collection)
        {
            try
            {
				// TODO: Add insert logic here
				PhoneBookDbEntities db = new PhoneBookDbEntities();
				Contact ac = new Contact();
				ac.ContactId = collection.ContactId;
				ac.PersonId = collection.PersonId;
				ac.Type = collection.Type;
				ac.ContactNumber = collection.ContactNumber;

				db.Contacts.Add(ac);
				db.SaveChanges();



				return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact/Edit/5
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

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
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
