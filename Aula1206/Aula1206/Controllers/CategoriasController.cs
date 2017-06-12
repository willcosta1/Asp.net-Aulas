using Aula1206.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1206.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria() { Nome = "Carros" });
            categorias.Add(new Categoria() { Nome = "Motos" });
            categorias.Add(new Categoria() { Nome = "Barcos" });
            categorias.Add(new Categoria() { Nome = "Aviões" });
            categorias.Add(new Categoria() { Nome = "Caminhões" });

            ViewBag.ListaCategorias = categorias;

            return View(categorias);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }
    }
}