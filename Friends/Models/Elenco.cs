using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class Elenco : Pessoa
    {
        public Elenco()
        {
            Curiosidades = new List<Curiosidade>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome do personagem é obrigatório")]
        [Display(Name = "Personagem",Prompt = "Nome do personagem na série")]
        public string Personagem { get; set; }
        public IList<Curiosidade> Curiosidades { get; set; }
       
        
    }
}
