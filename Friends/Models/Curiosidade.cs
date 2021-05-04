using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Friends.Models
{
    public class Curiosidade
    {
        public int Id { get; set; }
        public Elenco Artista { get; set; }
        public Episodio Episodio { get; set; }
        [Required(ErrorMessage = "Descrição obrigatório")]
        [Display(Prompt = "Descreva a curiosidade que quer adicionar")]
        public string Descricao { get; set; }
    }
}

