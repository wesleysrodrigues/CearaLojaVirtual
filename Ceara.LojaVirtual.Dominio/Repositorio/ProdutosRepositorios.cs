using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ceara.LojaVirtual.Dominio.Entidades;

namespace Ceara.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorios
    {

        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }


    }
}
