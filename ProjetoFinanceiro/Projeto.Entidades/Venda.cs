using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Venda
    {
        public int idVenda { get; set; }
        public DateTime data { get; set; }
        public decimal valor { get; set; }
        public double taxa { get; set; }

        public Pagamento pagamento { get; set; }
        public Cliente cliente { get; set; }
        public Vendedor vendedor { get; set; }

        public List<Produto> produtos { get; set; }
    }
}
