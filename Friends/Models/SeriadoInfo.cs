using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Friends.Models
{
    public class SeriadoInfo
    {
        public SeriadoInfo()
        {
            Elenco = new List<Elenco>();
            Curiosidade = new List<Curiosidade>();
            Critica = new List<Critica>();
            Criadores = new List<CriadoPor>();
        }
        public int Id { get; set; }
        public string ResumodaSerie { get; set; }
        public IList<Elenco> Elenco { get; set; }
        public IList<CriadoPor> Criadores { get; set; }
        public string Genero => "SitCom";
        public string MusicadeAbertura => "I'll be there for you";
        public int TotaldeTemporadas => 10;
        public int TotaldeEpisodios => 236;
        public DateTime QuandoLancou { get; set; }
        public DateTime QuandoTerminou { get; set; }
        public IList<Curiosidade> Curiosidade { get; set; }
        public IList<Critica> Critica { get; set; }
        public string InfoSerie { get; set; }

    }
}
