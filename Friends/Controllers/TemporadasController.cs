using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Friends.Models;
using Friends.Dados;
using Microsoft.EntityFrameworkCore;

namespace Friends.Controllers
{
    public class TemporadasController : Controller
    {

        private readonly ApplicationContext _context;

        public TemporadasController(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Listar as temporadas da série
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var temporadas = _context.Temporadas;

            return View(temporadas);
        }

        public IActionResult Episodios(byte numeroTemporada)
        {
            ViewData["NumeroTemporada"] = numeroTemporada;

            var episodio = _context.Episodios
                .Include(t => t.Temporada)
                .Where(e => e.Temporada.Numero == numeroTemporada);

            return View(episodio);
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
