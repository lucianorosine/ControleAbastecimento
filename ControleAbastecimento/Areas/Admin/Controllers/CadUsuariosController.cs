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
    public class CadUsuariosController : Controller
    {
        private BDAbastecimentoEntities1 db = new BDAbastecimentoEntities1();

        // GET: Admin/CadUsuarios
        public ActionResult Index()
        {
            return View(db.CadUsuario.ToList());
        }

        // GET: Admin/CadUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuario.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // GET: Admin/CadUsuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CadUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUsuario,Nome,Email,DataCadastro,Senha,Inativo")] CadUsuario cadUsuario)
        {
            if (ModelState.IsValid)
            {
                db.CadUsuario.Add(cadUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadUsuario);
        }

        // GET: Admin/CadUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuario.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // POST: Admin/CadUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUsuario,Nome,Email,DataCadastro,Senha,Inativo")] CadUsuario cadUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadUsuario);
        }

        // GET: Admin/CadUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuario.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // POST: Admin/CadUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadUsuario cadUsuario = db.CadUsuario.Find(id);
            db.CadUsuario.Remove(cadUsuario);
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
