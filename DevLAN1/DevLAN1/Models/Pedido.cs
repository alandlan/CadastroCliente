using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevLAN.Models
{
    public class Pedido : Entity
    {
        public Guid ClienteId { get; set; }

        public Guid ProdutoId { get; set; }
        public DateTime DataCadastro { get; set; }

        public Cliente Cliente { get; set; }

        public Produto Produto { get; set; }
    }
}
