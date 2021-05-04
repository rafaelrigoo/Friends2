using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class Quiz
    {
        public Quiz()
        {
            Alternativas = new List<Alternativa>();
        }
        public int Id { get; set; }

        public string Pergunta { get; set; }
        public IList<Alternativa> Alternativas { get; set; }
              
    }
}
