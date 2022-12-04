using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace guia_semana_16.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bienvenida(string name, int edad = 1)
        {
            ViewData["name"] = "Hola " + name;
            ViewData["edad"] = edad;
            return View();
        }

        public string Parameters(string name, int edad = 1)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, tu edad es: {edad} años");
        }
    }
}
