using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Simulation.Models;

namespace Simulation.Controllers
{
    public class PREREQUISITEsController : Controller
    {
        private ITSEntities db = new ITSEntities();

        // GET: PREREQUISITEs
        public ActionResult Index()
        {
            return View(db.PREREQUISITEs.ToList());
        }

        // GET: PREREQUISITEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PREREQUISITE pREREQUISITE = db.PREREQUISITEs.Find(id);
            if (pREREQUISITE == null)
            {
                return HttpNotFound();
            }
            return View(pREREQUISITE);
        }

        // GET: PREREQUISITEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PREREQUISITEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TopicID,Pre_TopicID,Pre_Type")] PREREQUISITE pREREQUISITE)
        {
            if (ModelState.IsValid)
            {
                db.PREREQUISITEs.Add(pREREQUISITE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pREREQUISITE);
        }

        // GET: PREREQUISITEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PREREQUISITE pREREQUISITE = db.PREREQUISITEs.Find(id);
            if (pREREQUISITE == null)
            {
                return HttpNotFound();
            }
            return View(pREREQUISITE);
        }

        // POST: PREREQUISITEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TopicID,Pre_TopicID,Pre_Type")] PREREQUISITE pREREQUISITE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pREREQUISITE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pREREQUISITE);
        }

        // GET: PREREQUISITEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PREREQUISITE pREREQUISITE = db.PREREQUISITEs.Find(id);
            if (pREREQUISITE == null)
            {
                return HttpNotFound();
            }
            return View(pREREQUISITE);
        }

        // POST: PREREQUISITEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PREREQUISITE pREREQUISITE = db.PREREQUISITEs.Find(id);
            db.PREREQUISITEs.Remove(pREREQUISITE);
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
