 using Friends.Dados;
using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class SeriadoInfoController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public SeriadoInfoController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public IActionResult Index()
        {
            var seriadoInfo = applicationContext.Informacoes.Include(s => s.Elenco).Include(s => s.Criadores).First();
            return View(seriadoInfo);
        }

        //pq quando deixo assim como argumento da erro e se eu colocar string funciona?
        public IActionResult InfoPessoal(string nome)
        {
            var artista = applicationContext.Elenco 
                .First(a => a.NomeReal == nome);
            return View(artista);
        }

        public IActionResult InfoSerie()
        {
            var infoSerie = applicationContext.Informacoes.First();
            return View(infoSerie);
        }

        public IActionResult Resumo()
        {
            var resumo = applicationContext.Informacoes.First();
            return View(resumo);
        }
    }
}
