using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class SeriadoInfoController : Controller
    {
        public IActionResult Index()
        {
            var joey = new Elenco();
            joey.Personagem = "Joey";
            joey.NomeReal = "Matthew Steven LeBlanc";
            

            var ross = new Elenco();
            ross.Personagem = "Ross";
            ross.NomeReal = "Ross";

            var david = new CriadoPor();
            david.NomeReal = "David Crane";
            


            var friends = new SeriadoInfo();

            friends.ResumodaSerie = "bla bla bla bla bla ";
           
            
            friends.Elenco.Add(ross);
            friends.Elenco.Add(joey);
            friends.Criadores.Add(david);

            return View(friends);
        }

        public IActionResult Producao()
        {
            var criadores = new SeriadoInfo();
            var elenco = new Elenco();
            var elenco2 = new Elenco();

            elenco.NomeReal = "David Crane";
            elenco2.NomeReal = "Marta";

            criadores.Elenco.Add(elenco);
            criadores.Elenco.Add(elenco2);
            


            return View(criadores);
        }
      
    }
}
