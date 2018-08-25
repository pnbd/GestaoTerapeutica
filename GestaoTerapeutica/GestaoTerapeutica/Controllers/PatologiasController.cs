using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestaoTerapeutica.Models;

namespace GestaoTerapeutica.Controllers
{
    public class PatologiasController : Controller
    {
        private MedsLarDb db = new MedsLarDb();

        // GET: Patologias
        public ActionResult Index()
        {
            return View(db.Patologias.ToList());
        }

        // GET: Patologias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patologia patologia = db.Patologias.Find(id);
            if (patologia == null)
            {
                return HttpNotFound();
            }
            return View(patologia);
        }

        // GET: Patologias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patologias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PatId,Nome,Especialidade")] Patologia patologia)
        {
            if (ModelState.IsValid)
            {
                db.Patologias.Add(patologia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patologia);
        }

        // GET: Patologias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patologia patologia = db.Patologias.Find(id);
            if (patologia == null)
            {
                return HttpNotFound();
            }
            return View(patologia);
        }

        // POST: Patologias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PatId,Nome,Especialidade")] Patologia patologia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patologia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patologia);
        }

        // GET: Patologias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patologia patologia = db.Patologias.Find(id);
            if (patologia == null)
            {
                return HttpNotFound();
            }
            return View(patologia);
        }

        // POST: Patologias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patologia patologia = db.Patologias.Find(id);
            db.Patologias.Remove(patologia);
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
