using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevLAN.Models
{
    public class Produto : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        public Decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        public int PorcentagemDesconto { get; set; }
        public Decimal ValorTotal { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; }
    }
}
