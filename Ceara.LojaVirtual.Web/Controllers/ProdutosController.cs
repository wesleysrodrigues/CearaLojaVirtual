using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ceara.LojaVirtual.Dominio.Repositorio;

namespace Ceara.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorios repositorio;
       
        // GET: Produtos
        public ActionResult Index()
        {
            repositorio = new ProdutosRepositorios();
            var produtos = repositorio.Produtos.Take(10);

            return View(produtos);
        }
    }
}