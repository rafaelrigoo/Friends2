using Friends.Dados;
using Friends.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarEpisodioController : Controller // CRUD - Create, Retrieve, Update, Delete
    {
        private readonly ApplicationContext applicationContext;

        public GerenciarEpisodioController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var episodios = applicationContext.Temporadas;
            return View(episodios);
        }


        public IActionResult IndexForm(Temporada temporada)
        {
            var episodios = applicationContext.Temporadas
                .Include(ep => ep.Episodios)
                .ThenInclude(a => a.ParticipacaoEspecial)
                .Where(ep => ep.Numero == temporada.Numero);
                
            return View(episodios);
        }

        [HttpGet]
        public IActionResult EditarEpisodio(int id, byte numTemporada)  // formulário para preencher os dados de episódio
        {
            var ep = applicationContext.Episodios
                .Include(t => t.Temporada)
                .FirstOrDefault(e => e.Id == id);

            if (ep != null)
            {
               // ep.Temporada = new Temporada { Numero = numTemporada };
                return View(ep);
            }
            TempData["Mensagem"] = $"Episódio com id {id} não existe!";
            return RedirectToAction("IndexForm", new { Numero = numTemporada }); //30x location: nova url
        }

        [HttpPost]
        public IActionResult EditarEpisodio(Episodio episodio) // recebe os dados de um episódio enviados pelo formulário, e salva no banco
        {
            // TODO: criar view model de edição de episódio com numero da temporada como propriedade
            if (ModelState.IsValid)
            {
                episodio.Temporada = applicationContext.Temporadas.First(t => t.Id == episodio.Temporada.Id);
                applicationContext.Episodios.Update(episodio);
                applicationContext.SaveChanges(); // UPDATE Episodios SET WHERE Id = ?

                return RedirectToAction("IndexForm", new { episodio.Temporada.Numero });
            }

            return View(episodio);
        }

        public IActionResult ExcluirEpisodio(int Id)
        {
            var ep = applicationContext.Episodios
                .Include(t => t.Temporada)
                .FirstOrDefault(e => e.Id == Id);

            if(ep != null)
            {
                applicationContext.Remove(ep);
                applicationContext.SaveChanges();
                TempData["Mensagem"] = "Episodio Excluido com Sucesso";
            }

            return RedirectToAction("IndexForm", new { ep.Temporada.Numero});
        }


    }
}
