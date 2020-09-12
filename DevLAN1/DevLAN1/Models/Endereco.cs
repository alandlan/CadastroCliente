using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevLAN.Models
{
    public class Endereco : Entity
    {
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 2)]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(200, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 2)]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(8, ErrorMessage = "O Campo {0} precisa ter entre {1} caracteres,", MinimumLength = 8)]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obtrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres,", MinimumLength = 2)]
        public string Estado { get; set; }

        public Cliente Cliente { get; set; }
    }
}
