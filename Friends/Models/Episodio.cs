using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


// Descricao do "sistema" >>>> Um site informativo sobre o seriado Friends. Principais informacoes dos episodios, curiosidades sobre o elenco,
//erros de gravacao e ficha completa dos artistas. 


namespace Friends.Models
{
    /// <summary>
    /// Representa um episodio na serie.
    /// </summary>
    public class Episodio
    {
        public Episodio()
        {

        }
        public Episodio(string nome, Temporada temporada)
        {
            Nome = nome;
            Temporada = temporada;
            ParticipacaoEspecial = new List<ParticipacaoEspecial>();
        }
        public int Id { get; set; }
        public int EpisodioId { get; set; }

        /// <summary>
        /// Nome do episodio.
        /// </summary>
        [Required(ErrorMessage = "Nome do episódio é obrigatório")]
        [Display(Prompt = "Nome do episódio")]
        public string Nome { get; set; }
        /// <summary>
        /// Temporada em que o episodio se encontra.
        /// </summary>
        
        [Required(ErrorMessage = "Número da Temporada é obrigatório")]
        public Temporada Temporada { get; set; }
        public DateTime QuandoFoiLancado { get; set; }

        /// <summary>
        /// Episodio teve a participacao de algum convidado especial.
        /// </summary>
        public IList<ParticipacaoEspecial> ParticipacaoEspecial { get; set; }
        /// <summary>
        /// Erros de gravacao.
        /// </summary>
        public string ErrosdeGravacao { get; set; }
        /// <summary>
        /// Breve descricao do episodio.
        /// </summary>
        
        public string Sinopse { get; set; }
        /// <summary>
        /// Equipe que trabalhou neste episodio.
        /// </summary>
      
    }
}
