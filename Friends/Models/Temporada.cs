using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class Temporada
    {
        public Temporada()
        {
            Episodios = new List<Episodio>();
            Elenco = new List<Elenco>();
        }
        public Temporada(byte numero) : this()
        {
            Numero = numero;
        }
        public int Id { get; set; }
        public int TemporadaId { get; set; }
        [Required(ErrorMessage = "Número da temporada é obrigatório")]
        public byte Numero { get; set; }
        public IList<Episodio> Episodios { get; set; }
        public IList<Elenco> Elenco { get; set; }
        public DateTime QuandoFoiLancada { get; set; }
        public DateTime QuandoTerminou { get; set; }
        public Episodio EpisodioMaisVisto { get; set; }
        public int QuantidadeEpisodios => Episodios.Count;
        public string CaminhoImagem { get; set; }
    }
}
