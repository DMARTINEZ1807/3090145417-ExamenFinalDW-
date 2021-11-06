using ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        private db_a7bcf6_hotelumgEntities db = new db_a7bcf6_hotelumgEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(string user, string pass)
        {
            EP_buscar_loginejercicio_Result u = db.EP_buscar_loginejercicio(user, pass).FirstOrDefault();

            if (u == null)//si no existe el usuario
            {
                string a = Convert.ToString(ViewData["Error"]);

                ViewData["Error"] = "si";
                return View();
            }
            ViewData["Error"] = "No";
            Session["usuario"] = u.usuario;
            Session["nombre"] = u.Nombre;
            Session["puesto"] = u.correo;

            return RedirectToAction("Menu", "Home");
        }

    }
}