using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryWebMvc.Models
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [EmailAddress(ErrorMessage = "Entre com email valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O tamanho do {0} deve ser no mínimo {2} e no maximo {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "O tamanho da {0} deve ser no mínimo {2}")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public bool? IsAdm { get; set; }

        public Congregation Congregation { get; set; }

        public int? CongregationId { get; set; }


    }
}
