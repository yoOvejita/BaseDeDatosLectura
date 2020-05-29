using BaseDeDatosLectura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseDeDatosLectura.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MostrarDatos() {
            EjemploASPNETEntities1 db = new EjemploASPNETEntities1();
            ViewBag.productos = db.Producto.ToList();
            return View();
        }
    }
}