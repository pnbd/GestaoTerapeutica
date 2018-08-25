using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestaoTerapeutica.Models;

namespace GestaoTerapeutica.Views
{
    public class FarmaciasController : Controller
    {
        private MedsLarDb db = new MedsLarDb();

        // GET: Farmacias
        public ActionResult Index()
        {
            return View(db.Farmacias.ToList());
        }

        // GET: Farmacias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmacia farmacia = db.Farmacias.Find(id);
            if (farmacia == null)
            {
                return HttpNotFound();
            }
            return View(farmacia);
        }

        // GET: Farmacias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Farmacias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FarmId,NomeFarm,MoradaRua,MoradaAndar,MoradaCodPost,ContactoTelefone,ContactoMail")] Farmacia farmacia)
        {
            if (ModelState.IsValid)
            {
                db.Farmacias.Add(farmacia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(farmacia);
        }

        // GET: Farmacias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmacia farmacia = db.Farmacias.Find(id);
            if (farmacia == null)
            {
                return HttpNotFound();
            }
            return View(farmacia);
        }

        // POST: Farmacias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FarmId,NomeFarm,MoradaRua,MoradaAndar,MoradaCodPost,ContactoTelefone,ContactoMail")] Farmacia farmacia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmacia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(farmacia);
        }

        // GET: Farmacias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmacia farmacia = db.Farmacias.Find(id);
            if (farmacia == null)
            {
                return HttpNotFound();
            }
            return View(farmacia);
        }

        // POST: Farmacias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Farmacia farmacia = db.Farmacias.Find(id);
            db.Farmacias.Remove(farmacia);
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
