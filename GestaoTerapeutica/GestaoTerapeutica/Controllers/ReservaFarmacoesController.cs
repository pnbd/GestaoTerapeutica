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
    public class ReservaFarmacoesController : Controller
    {
        private MedsLarDb db = new MedsLarDb();

        // GET: ReservaFarmacoes
        public ActionResult Index()
        {
            var reservas = db.Reservas.Include(r => r.Farmacia).Include(r => r.Utente);
            return View(reservas.ToList());
        }

        // GET: ReservaFarmacoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservaFarmaco reservaFarmaco = db.Reservas.Find(id);
            if (reservaFarmaco == null)
            {
                return HttpNotFound();
            }
            return View(reservaFarmaco);
        }

        // GET: ReservaFarmacoes/Create
        public ActionResult Create()
        {
            ViewBag.FarmaciaId = new SelectList(db.Farmacias, "FarmId", "NomeFarm");
            ViewBag.UtenteId = new SelectList(db.Utentes, "UtenteId", "Nome");
            return View();
        }

        // POST: ReservaFarmacoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReservaId,CNP,SubstAct,FormaFarm,Dose,LinkRCM,PosologiaDia,PosologiaSemana,PosologiaMes,CompExistentes,UtenteId,FarmaciaId")] ReservaFarmaco reservaFarmaco)
        {
            if (ModelState.IsValid)
            {
                db.Reservas.Add(reservaFarmaco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FarmaciaId = new SelectList(db.Farmacias, "FarmId", "NomeFarm", reservaFarmaco.FarmaciaId);
            ViewBag.UtenteId = new SelectList(db.Utentes, "UtenteId", "Nome", reservaFarmaco.UtenteId);
            return View(reservaFarmaco);
        }

        // GET: ReservaFarmacoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservaFarmaco reservaFarmaco = db.Reservas.Find(id);
            if (reservaFarmaco == null)
            {
                return HttpNotFound();
            }
            ViewBag.FarmaciaId = new SelectList(db.Farmacias, "FarmId", "NomeFarm", reservaFarmaco.FarmaciaId);
            ViewBag.UtenteId = new SelectList(db.Utentes, "UtenteId", "Nome", reservaFarmaco.UtenteId);
            return View(reservaFarmaco);
        }

        // POST: ReservaFarmacoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReservaId,CNP,SubstAct,FormaFarm,Dose,LinkRCM,PosologiaDia,PosologiaSemana,PosologiaMes,CompExistentes,UtenteId,FarmaciaId")] ReservaFarmaco reservaFarmaco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reservaFarmaco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FarmaciaId = new SelectList(db.Farmacias, "FarmId", "NomeFarm", reservaFarmaco.FarmaciaId);
            ViewBag.UtenteId = new SelectList(db.Utentes, "UtenteId", "Nome", reservaFarmaco.UtenteId);
            return View(reservaFarmaco);
        }

        // GET: ReservaFarmacoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservaFarmaco reservaFarmaco = db.Reservas.Find(id);
            if (reservaFarmaco == null)
            {
                return HttpNotFound();
            }
            return View(reservaFarmaco);
        }

        // POST: ReservaFarmacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReservaFarmaco reservaFarmaco = db.Reservas.Find(id);
            db.Reservas.Remove(reservaFarmaco);
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
