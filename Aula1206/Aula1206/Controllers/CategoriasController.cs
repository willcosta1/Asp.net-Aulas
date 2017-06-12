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

            categorias.Add(new Categoria() { Nome = "Carros", Descricao = "Os carros são como os barcos" });
            categorias.Add(new Categoria() { Nome = "Motos", Descricao = "As motos são como os jetski" });
            categorias.Add(new Categoria() { Nome = "Barcos", Descricao = "Os barcos são como os carros" });
            categorias.Add(new Categoria() { Nome = "Aviões", Descricao = "asfaf" });
            categorias.Add(new Categoria() { Nome = "Caminhões"});

            ViewBag.ListaCategorias = categorias;

            return View(categorias);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Categoria Categoria)
        {
            //Validação
            return View(Categoria);
        }
    }
}