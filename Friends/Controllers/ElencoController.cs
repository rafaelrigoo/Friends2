using Friends.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class ElencoController : Controller
    {
        public IActionResult Index()
        {
            var monica = new Elenco();
            monica.Personagem = "Monica";
            monica.Nacionalidade = "Estados Unidos";
            monica.CaminhoImagem = "/imagens/monicageller.jpg";

            var joey = new Elenco();
            joey.Personagem = "Joey";
            joey.NomeReal = "Joey";
            joey.CaminhoImagem = "/imagens/joeytribiani.jpg";

            var rachel = new Elenco();
            rachel.CaminhoImagem = "/imagens/rachelgreen.jpg";
            rachel.NomeReal = "Rachel";
            rachel.Personagem = "Rachel";

            var ross = new Elenco();
            ross.CaminhoImagem = "/imagens/rossgeller.jpg";
            ross.Personagem = "Ross";

            var phoebe = new Elenco();
            phoebe.CaminhoImagem = "/imagens/phoebebuffay.jpg";
            phoebe.Personagem = "Phoebe";

            var chandler = new Elenco();
            chandler.CaminhoImagem = "/imagens/chandlerbing.jpg";


            var joeylista = new List<Elenco>() {  joey, phoebe, rachel, monica, ross,chandler };

            return View(joeylista);
        }

      
        public IActionResult FichaCompleta(Elenco artista)
        {
            return View(artista);
        }
    }
}
