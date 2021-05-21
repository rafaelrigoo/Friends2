using Friends.Dados;
using Friends.Models;
using Friends.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class GerenciarElencoController : Controller
    {
        private readonly ApplicationContext applicationContext;
        private readonly IWebHostEnvironment webHost;

        public GerenciarElencoController(ApplicationContext applicationContext, IWebHostEnvironment webHost)
        {
            this.applicationContext = applicationContext;
            this.webHost = webHost;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var elenco = applicationContext.Elenco;
            return View(elenco);
        }

        [HttpGet]
        public IActionResult EditarElenco(int Id)
        {
            var artista = applicationContext.Elenco
                .FirstOrDefault(a => a.Id == Id);

            var model = new ElencoViewModel()
            {
                Id = artista.Id,
                EstadoCivil = artista.EstadoCivil,
                DatadeNascimento = artista.DatadeNascimento,
                CaminhoImagem = artista.CaminhoImagem,
                NomeReal = artista.NomeReal,
                Personagem = artista.Personagem,
                QuantidadedeFilhos = artista.QuantidadedeFilhos,
                ResumoPersonagem = artista.ResumoPersonagem,
                Carreira = artista.Carreira

            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditarElenco(ElencoViewModel model)
        {
           if(ModelState.IsValid)
            {
                var nomeArquivo = Path.Combine(webHost.WebRootPath, "imagens", model.ImagemElenco.FileName);
                using (var writer = new FileStream(nomeArquivo, FileMode.Create))
                {
                    model.ImagemElenco.CopyTo(writer);
                }

                // pegar o arquivo e gravar na pasta /imagens; retornar o caminha relativo do arquvo /imagens/<nome do arquvo>.ext
                var caminhoImagem = $"/imagens/{model.ImagemElenco.FileName}";

                Elenco elenco = new Elenco();
                elenco.Id = model.Id;
                elenco.EstadoCivil = model.EstadoCivil;
                elenco.DatadeNascimento = model.DatadeNascimento;
                elenco.CaminhoImagem = caminhoImagem;
                elenco.NomeReal = model.NomeReal;
                elenco.Personagem = model.Personagem;
                elenco.QuantidadedeFilhos = model.QuantidadedeFilhos;
                elenco.ResumoPersonagem = model.ResumoPersonagem;
                elenco.Carreira = model.Carreira;

                if (elenco.Id != 0)
                  applicationContext.Elenco.Update(elenco); 
                
                else
                 applicationContext.Elenco.Add(elenco);
                


                applicationContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

       
        public IActionResult ExcluirElenco(int Id)
        {
            var artista = applicationContext.Elenco
                .FirstOrDefault(a => a.Id == Id);

            if(artista != null)
            {
                applicationContext.Remove(artista);
                applicationContext.SaveChanges();
            }

            TempData["Msg"] = "Artista removido com sucesso";

            return RedirectToAction("Index");
        }
    }
}
