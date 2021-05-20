using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.ViewModel
{
    public class ElencoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do personagem é obrigatório")]
        [Display(Name = "Personagem", Prompt = "Nome do personagem na série")]
        public string Personagem { get; set; }
        public string NomeReal { get; set; }
        public string Nacionalidade { get; set; }

        public DateTime DatadeNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public int QuantidadedeFilhos { get; set; }
        public string CaminhoImagem { get; set; }
        public IFormFile ImagemElenco { get; set; }
        public string ResumoPersonagem { get; set; }
        public string Carreira { get; set; }
    }
}
