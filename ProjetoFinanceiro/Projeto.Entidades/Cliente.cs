using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public bool ativo { get; set; }

        public Endereco endereco { get; set; }
        public List<Venda> vendas { get; set; }
    }
}
