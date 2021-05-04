using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Friends.Models;

namespace Friends.Controllers
{
    public class TemporadasController : Controller
    {
        /// <summary>
        /// Listar as temporadas da série
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            
            var temporada1 = new Temporada(1);
            temporada1.CaminhoImagem = "/imagens/temporada1capa.jpg";

            var temporada2 = new Temporada(2);
            temporada2.CaminhoImagem = "/imagens/temporada2capa.jpg";

            var temporada3 = new Temporada(3);
            temporada3.CaminhoImagem = "/imagens/temporada3novacapa.jpg";

            var temporada4 = new Temporada(4);
            temporada4.CaminhoImagem = "/imagens/temporada4capa.jpg";

            var temporada5 = new Temporada(5);
            temporada5.CaminhoImagem = "/imagens/temporada5capanova.jpg";


            var episodio1 = new Episodio("The Pilot", temporada1);
            var episodio2 = new Episodio("The One with the Sonogram at the End", temporada1);

            temporada1.Episodios.Add(episodio1);
            temporada1.Episodios.Add(episodio2);

            var temporadas = new List<Temporada>
            {
                temporada1, temporada2, temporada3, temporada4, temporada5
            };

            return View(temporadas);
        }

        public IActionResult Episodios(byte numeroTemporada)
        {
            ViewData["NumeroTemporada"] = numeroTemporada;
            var temporada = new Temporada(1);
            var episodio1 = new Episodio("The Pilot", temporada);
            var episodio2 = new Episodio("The One with the Sonogram at the End", temporada);

            var episodios = new List<Episodio>
            {
                episodio1, episodio2
            };

            return View(episodios);
        }


      
        public IActionResult InformacoesEpisodio()
        {
            var episodio1 = new Episodio("The Pilot", new Temporada(1));
            episodio1.Sinopse = "Monica, Joey, Chandler e Phoebe estão de bobeira no Central Perk, falando sobre o encontro de Monica á noite." +
                " Ross chega, e com um melancólico 'Oi' se junta ao grupo. Carol, sua ex-esposa lésbica, finalmente se mudou de seu apartamento. " +
                "A discussão de repente muda para esse assunto, e Ross diz que deseja estar casado denovo, e sentir falta de Carol." +
                " E é aí que Rachel entra eufórica em seu vestido de noiva, e Chandler grita 'E eu desejo um milhão de dólares!'." +
                " Aparentemente, Rachel estava procurando por Monica para dizê-la que ela finalmente se ligou que não ama seu futuro marido, e por isso fugiu do casamento.";
            var listaepisodios = new List<Episodio>() { episodio1 };

            return View(listaepisodios);
        }
    }
}
