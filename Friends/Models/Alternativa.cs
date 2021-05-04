using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class Alternativa
    {
        public Alternativa(string opcaodeResposta, bool alternativaCorreta)
        {
            OpcaodeResposta = opcaodeResposta;
            AlternativaCorreta = alternativaCorreta;
        }

        public int Id { get; set; }
        public string OpcaodeResposta { get; set; }
        public bool AlternativaCorreta { get; set; }
    }
}
