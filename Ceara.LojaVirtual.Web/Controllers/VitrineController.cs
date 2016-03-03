using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ceara.LojaVirtual.Dominio.Repositorio;

namespace Ceara.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorios repositorio;
        public int ProdutosPorPaginas = 5;
        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina=1)
        {
            repositorio = new ProdutosRepositorios();
            var produtos = repositorio.Produtos
                .OrderBy(p => p.Nome)
                .Skip((pagina -1) * ProdutosPorPaginas)
                .Take(ProdutosPorPaginas);

            return View(produtos);

        }
    }
}