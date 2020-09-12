using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevLAN.Models
{
    public class Cliente : Entity
    {
        public Guid EnderecoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(14, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 11)]
        public string Documento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 8)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 8)]
        public string Celular { get; set; }
        public Endereco Endereco { get; set; }

        public IEnumerable<Pedido> Pedidos { get; set; }

    }
}
