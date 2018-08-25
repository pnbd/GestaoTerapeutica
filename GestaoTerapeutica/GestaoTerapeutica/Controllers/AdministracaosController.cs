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
    public class AdministracaosController : Controller
    {
        private MedsLarDb db = new MedsLarDb();

        // GET: Administracaos
        public ActionResult Index()
        {
            var administracoes = db.Administracoes.Include(a => a.Funcionario).Include(a => a.ReservaFarmaco);
            return View(administracoes.ToList());
        }

        // GET: Administracaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administracao administracao = db.Administracoes.Find(id);
            if (administracao == null)
            {
                return HttpNotFound();
            }
            return View(administracao);
        }

        // GET: Administracaos/Create
        public ActionResult Create()
        {
            ViewBag.FuncFk = new SelectList(db.Funcionarios, "FuncId", "NomeFunc");
            ViewBag.ReservaFk = new SelectList(db.Reservas, "ReservaId", "SubstAct");
            return View();
        }

        // POST: Administracaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdminId,DataAdmin,FuncFk,ReservaFk")] Administracao administracao)
        {
            if (ModelState.IsValid)
            {
                db.Administracoes.Add(administracao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FuncFk = new SelectList(db.Funcionarios, "FuncId", "NomeFunc", administracao.FuncFk);
            ViewBag.ReservaFk = new SelectList(db.Reservas, "ReservaId", "SubstAct", administracao.ReservaFk);
            return View(administracao);
        }

        // GET: Administracaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administracao administracao = db.Administracoes.Find(id);
            if (administracao == null)
            {
                return HttpNotFound();
            }
            ViewBag.FuncFk = new SelectList(db.Funcionarios, "FuncId", "NomeFunc", administracao.FuncFk);
            ViewBag.ReservaFk = new SelectList(db.Reservas, "ReservaId", "SubstAct", administracao.ReservaFk);
            return View(administracao);
        }

        // POST: Administracaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdminId,DataAdmin,FuncFk,ReservaFk")] Administracao administracao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administracao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FuncFk = new SelectList(db.Funcionarios, "FuncId", "NomeFunc", administracao.FuncFk);
            ViewBag.ReservaFk = new SelectList(db.Reservas, "ReservaId", "SubstAct", administracao.ReservaFk);
            return View(administracao);
        }

        // GET: Administracaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administracao administracao = db.Administracoes.Find(id);
            if (administracao == null)
            {
                return HttpNotFound();
            }
            return View(administracao);
        }

        // POST: Administracaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Administracao administracao = db.Administracoes.Find(id);
            db.Administracoes.Remove(administracao);
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
