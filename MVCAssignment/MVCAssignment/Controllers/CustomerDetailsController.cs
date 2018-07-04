using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCAssignment.Models;

namespace MVCAssignment.Controllers
{
    public class CustomerDetailsController : Controller
    {
        private CustomerDetailsDBContext db = new CustomerDetailsDBContext();

        // GET: CustomerDetails
        public ActionResult Index()
        {
            return View(db.CustomerDetailsDB.ToList());
        }

        // GET: CustomerDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDetails customerDetails = db.CustomerDetailsDB.Find(id);
            if (customerDetails == null)
            {
                return HttpNotFound();
            }
            return View(customerDetails);
        }

        // GET: CustomerDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerDetailsId,Name,Address")] CustomerDetails customerDetails)
        {
            if (ModelState.IsValid)
            {
                db.CustomerDetailsDB.Add(customerDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerDetails);
        }

        // GET: CustomerDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDetails customerDetails = db.CustomerDetailsDB.Find(id);
            if (customerDetails == null)
            {
                return HttpNotFound();
            }
            return View(customerDetails);
        }

        // POST: CustomerDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerDetailsId,Name,Address")] CustomerDetails customerDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerDetails);
        }

        // GET: CustomerDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDetails customerDetails = db.CustomerDetailsDB.Find(id);
            if (customerDetails == null)
            {
                return HttpNotFound();
            }
            return View(customerDetails);
        }

        // POST: CustomerDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerDetails customerDetails = db.CustomerDetailsDB.Find(id);
            db.CustomerDetailsDB.Remove(customerDetails);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
