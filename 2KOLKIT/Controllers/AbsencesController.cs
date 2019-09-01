using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2KOLKIT.Models;

namespace _2KOLKIT.Controllers
{

    public class AbsencesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Absences
        [Authorize(Roles = "Administrator,Director,Employee")]

        public ActionResult Index()
        {
            var absences = db.Absences.Include(a => a.Employee);
            return View(absences.ToList());
        }
        [Authorize(Roles = "Administrator,Director")]


        // GET: Absences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            return View(absence);
        }

        // GET: Absences/Create
        [Authorize(Roles = "Administrator,Director")]


        public ActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name");
            return View();
        }

        // POST: Absences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator,Director")]

        [Authorize(Roles = "Administrator,Director")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AbsenceId,Description,EmployeeId")] Absence absence)
        {
            if (ModelState.IsValid)
            {
                db.Absences.Add(absence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", absence.EmployeeId);
            return View(absence);
        }
        [Authorize(Roles = "Administrator,Director")]

        // GET: Absences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", absence.EmployeeId);
            return View(absence);
        }
        [Authorize(Roles = "Administrator,Director")]

        // POST: Absences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AbsenceId,Description,EmployeeId")] Absence absence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(absence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", absence.EmployeeId);
            return View(absence);
        }
        [Authorize(Roles = "Administrator,Director")]

        // GET: Absences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            return View(absence);
        }
        [Authorize(Roles = "Administrator,Director")]

        // POST: Absences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Absence absence = db.Absences.Find(id);
            db.Absences.Remove(absence);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Administrator,Director")]

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        [Authorize(Roles ="Director")]
        
        public ActionResult Approved(int id)
        {
            Absence model = db.Absences.Find(id);
            model.isApproved = true;
            db.SaveChanges();
            return RedirectToAction("Index", "Absences");
            
        }
    }
}
