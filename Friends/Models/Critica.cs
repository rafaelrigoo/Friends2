using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class Critica
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fonte da crítica é obrigatória")]
        [Display(Prompt = "Fonte da crítica")]
        public string Fonte { get; set; }

        [Required(ErrorMessage = "Nota é obrigatória")]
        [Display(Prompt = "Nota recebida pela crítica")]
        public string Nota { get; set; }

        [Display(Prompt = "Comentário feito pelo crítico")]
        public string Comentario { get; set; }
    }
}
