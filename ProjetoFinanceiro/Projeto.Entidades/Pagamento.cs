using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Pagamento
    {
        public int idPagamento { get; set; }
        public int numeroPagamento { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public Venda venda { get; set; }
    }
}
