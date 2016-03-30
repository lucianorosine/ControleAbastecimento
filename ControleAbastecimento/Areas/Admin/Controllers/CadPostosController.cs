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
    public class CadPostosController : Controller
    {
        private BDAbastecimentoEntities1 db = new BDAbastecimentoEntities1();

        // GET: Admin/CadPostos
        public ActionResult Index()
        {
            return View(db.CadPosto.ToList());
        }

        // GET: Admin/CadPostos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadPosto cadPosto = db.CadPosto.Find(id);
            if (cadPosto == null)
            {
                return HttpNotFound();
            }
            return View(cadPosto);
        }

        // GET: Admin/CadPostos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CadPostos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CNPJ,Nome,Endereco,Bairro,Cidade,Estado,Bandeira")] CadPosto cadPosto)
        {
            if (ModelState.IsValid)
            {
                db.CadPosto.Add(cadPosto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadPosto);
        }

        // GET: Admin/CadPostos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadPosto cadPosto = db.CadPosto.Find(id);
            if (cadPosto == null)
            {
                return HttpNotFound();
            }
            return View(cadPosto);
        }

        // POST: Admin/CadPostos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CNPJ,Nome,Endereco,Bairro,Cidade,Estado,Bandeira")] CadPosto cadPosto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadPosto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadPosto);
        }

        // GET: Admin/CadPostos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadPosto cadPosto = db.CadPosto.Find(id);
            if (cadPosto == null)
            {
                return HttpNotFound();
            }
            return View(cadPosto);
        }

        // POST: Admin/CadPostos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CadPosto cadPosto = db.CadPosto.Find(id);
            db.CadPosto.Remove(cadPosto);
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
