using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public abstract class Pessoa
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string NomeReal { get; set; }
        public string Nacionalidade { get; set; }
        
        public DateTime DatadeNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public int QuantidadedeFilhos { get; set; }
        public string CaminhoImagem { get; set; }
    }
}
