﻿using System;
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
    public class UtentesController : Controller
    {
        private MedsLarDb db = new MedsLarDb();

        // GET: Utentes
        public ActionResult Index()
        {
            return View(db.Utentes.ToList());
        }

        // GET: Utentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utente utente = db.Utentes.Find(id);
            if (utente == null)
            {
                return HttpNotFound();
            }
            return View(utente);
        }

        // GET: Utentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Utentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UtenteId,Nome,DataNascimento")] Utente utente)
        {
            if (ModelState.IsValid)
            {
                db.Utentes.Add(utente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(utente);
        }

        // GET: Utentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utente utente = db.Utentes.Find(id);
            if (utente == null)
            {
                return HttpNotFound();
            }
            return View(utente);
        }

        // POST: Utentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UtenteId,Nome,DataNascimento")] Utente utente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(utente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(utente);
        }

        // GET: Utentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utente utente = db.Utentes.Find(id);
            if (utente == null)
            {
                return HttpNotFound();
            }
            return View(utente);
        }

        // POST: Utentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Utente utente = db.Utentes.Find(id);
            db.Utentes.Remove(utente);
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
