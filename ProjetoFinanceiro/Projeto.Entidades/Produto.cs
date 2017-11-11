using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string nome { get; set; }
        public decimal precoUnitario { get; set; }

        public Categoria categoria { get; set; }
    }
}
