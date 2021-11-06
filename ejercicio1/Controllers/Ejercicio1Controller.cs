using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ejercicio1.Models;

namespace ejercicio1.Controllers
{
    public class Ejercicio1Controller : Controller
    {
        private db_a7bcf6_hotelumgEntities db = new db_a7bcf6_hotelumgEntities();

        // GET: Ejercicio1
        public ActionResult Index()
        {
            return View(db.Ejercicio1.ToList());
        }

        // GET: Ejercicio1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ejercicio1 ejercicio1 = db.Ejercicio1.Find(id);
            if (ejercicio1 == null)
            {
                return HttpNotFound();
            }
            return View(ejercicio1);
        }

        // GET: Ejercicio1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ejercicio1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "usuario,contraseña,Nombre,correo,Tipousuario")] Ejercicio1 ejercicio1)
        {
            if (ModelState.IsValid)
            {
                db.Ejercicio1.Add(ejercicio1);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Create");
            
        }

        // GET: Ejercicio1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ejercicio1 ejercicio1 = db.Ejercicio1.Find(id);
            if (ejercicio1 == null)
            {
                return HttpNotFound();
            }
            return View(ejercicio1);
        }

        // POST: Ejercicio1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "usuario,contraseña,Nombre,correo,Tipousuario")] Ejercicio1 ejercicio1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ejercicio1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ejercicio1);
        }

        // GET: Ejercicio1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ejercicio1 ejercicio1 = db.Ejercicio1.Find(id);
            if (ejercicio1 == null)
            {
                return HttpNotFound();
            }
            return View(ejercicio1);
        }

        // POST: Ejercicio1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ejercicio1 ejercicio1 = db.Ejercicio1.Find(id);
            db.Ejercicio1.Remove(ejercicio1);
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
