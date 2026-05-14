using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class HomeController : Controller
    {
        // Metodos de resolucion : ActionResult
        // Tener metodos genericos de diferentes de datos de devolucion

        // Redirigir
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("Index", "Pruebas");
        }

        // Hacer redireccionamiento a otras paginas existentes URL : RedirectResult()
        //public RedirectResult Index()
        //{
        //    return Redirect("https://google.com");
        //}


        // Lanzar una cadena de texto: ContentResult

        //public ContentResult Index()
        //{
        //    return Content("Diego Alejandro ASP.NET");
        //} 

        // Lanzar una vista: ViewResult

        /*
        public ViewResult Index()
        {
            return View();
        } */

        // Lanzar formatos JSON

        //public JsonResult Index()
        //{
        //    var alumno1 = new Persona()
        //    {
        //        Nombre = "Juan",
        //        Edad = 32,
        //        Empleado = true
        //    };

        //    var alumno2 = new Persona()
        //    {
        //        Nombre = "Mario",
        //        Edad = 23,
        //        Empleado = false
        //    };

        //    //return View();
        //    return Json(new List<Persona>() { alumno1, alumno2}, JsonRequestBehavior.AllowGet);

        //}




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
    }
}