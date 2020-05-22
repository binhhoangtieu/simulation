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
    public class STYLE_WEIGHTController : Controller
    {
        private ITSEntities db = new ITSEntities();

        // GET: STYLE_WEIGHT
        public ActionResult Index()
        {
            return View(db.STYLE_WEIGHT.ToList());
        }

        // GET: STYLE_WEIGHT/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STYLE_WEIGHT sTYLE_WEIGHT = db.STYLE_WEIGHT.Find(id);
            if (sTYLE_WEIGHT == null)
            {
                return HttpNotFound();
            }
            return View(sTYLE_WEIGHT);
        }

        // GET: STYLE_WEIGHT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: STYLE_WEIGHT/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Style,Vis,Ver,Act,Ref,Seg,Glo,Sen,Int,Bloom1,Bloom2,Bloom3,Bloom4,Bloom5,Bloom6,Interesting,NotInteresting")] STYLE_WEIGHT sTYLE_WEIGHT)
        {
            if (ModelState.IsValid)
            {
                db.STYLE_WEIGHT.Add(sTYLE_WEIGHT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sTYLE_WEIGHT);
        }

        // GET: STYLE_WEIGHT/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STYLE_WEIGHT sTYLE_WEIGHT = db.STYLE_WEIGHT.Find(id);
            if (sTYLE_WEIGHT == null)
            {
                return HttpNotFound();
            }
            return View(sTYLE_WEIGHT);
        }

        // POST: STYLE_WEIGHT/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Style,Vis,Ver,Act,Ref,Seg,Glo,Sen,Int,Bloom1,Bloom2,Bloom3,Bloom4,Bloom5,Bloom6,Interesting,NotInteresting")] STYLE_WEIGHT sTYLE_WEIGHT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sTYLE_WEIGHT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sTYLE_WEIGHT);
        }

        // GET: STYLE_WEIGHT/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STYLE_WEIGHT sTYLE_WEIGHT = db.STYLE_WEIGHT.Find(id);
            if (sTYLE_WEIGHT == null)
            {
                return HttpNotFound();
            }
            return View(sTYLE_WEIGHT);
        }

        // POST: STYLE_WEIGHT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            STYLE_WEIGHT sTYLE_WEIGHT = db.STYLE_WEIGHT.Find(id);
            db.STYLE_WEIGHT.Remove(sTYLE_WEIGHT);
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
