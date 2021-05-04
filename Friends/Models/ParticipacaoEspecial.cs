using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class ParticipacaoEspecial : Elenco
    {
        public Episodio QuandoAparece { get; set; }
        public int QuantosEpisodiosAparece { get; set; }

    }
}
