using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControleAbastecimento.Areas.Admin.Models;

namespace ControleAbastecimento.Areas.Admin.Controllers
{
    public class CadMotoristasController : Controller
    {
        private BDAbastecimentoEntities1 db = new BDAbastecimentoEntities1();

        // GET: Admin/CadMotoristas
        public ActionResult Index()
        {
            return View(db.CadMotorista.ToList());
        }

        // GET: Admin/CadMotoristas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadMotorista cadMotorista = db.CadMotorista.Find(id);
            if (cadMotorista == null)
            {
                return HttpNotFound();
            }
            return View(cadMotorista);
        }

        // GET: Admin/CadMotoristas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CadMotoristas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CPF,Nome,Telefone")] CadMotorista cadMotorista)
        {
            if (ModelState.IsValid)
            {
                db.CadMotorista.Add(cadMotorista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadMotorista);
        }

        // GET: Admin/CadMotoristas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadMotorista cadMotorista = db.CadMotorista.Find(id);
            if (cadMotorista == null)
            {
                return HttpNotFound();
            }
            return View(cadMotorista);
        }

        // POST: Admin/CadMotoristas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CPF,Nome,Telefone")] CadMotorista cadMotorista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadMotorista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadMotorista);
        }

        // GET: Admin/CadMotoristas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadMotorista cadMotorista = db.CadMotorista.Find(id);
            if (cadMotorista == null)
            {
                return HttpNotFound();
            }
            return View(cadMotorista);
        }

        // POST: Admin/CadMotoristas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CadMotorista cadMotorista = db.CadMotorista.Find(id);
            db.CadMotorista.Remove(cadMotorista);
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
