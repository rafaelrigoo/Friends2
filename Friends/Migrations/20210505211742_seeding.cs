using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Friends.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 1, "/imagens/temporada1.jpg", new DateTime(1994, 09, 22), new DateTime(1995,05,1995) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 2, "/imagens/temporada2.jpg", new DateTime(1995, 09, 21), new DateTime(1996, 05, 16) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 3, "/imagens/temporada3.jpg", new DateTime(1996, 09, 19), new DateTime(1997, 05, 15) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 4, "/imagens/temporada4.jpg", new DateTime(1997, 09, 25), new DateTime(1998, 05, 07) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 5, "/imagens/temporada5.jpg", new DateTime(1998, 09, 24), new DateTime(1999, 05, 20) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 6, "/imagens/temporada6.jpg", new DateTime(1999, 09, 23), new DateTime(2000, 05, 18) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 7, "/imagens/temporada7.jpg", new DateTime(2000, 10, 12), new DateTime(2001, 05, 17) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 8, "/imagens/temporada8.jpg", new DateTime(2001, 09, 27), new DateTime(2002, 05, 16) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 9, "/imagens/temporada9.jpg", new DateTime(2002, 09, 26), new DateTime(2003, 05, 15) });
            migrationBuilder.InsertData("Temporadas", new string[] { "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 10, "/imagens/temporada10.jpg", new DateTime(2003, 09, 25), new DateTime(2004, 05, 06) });


            migrationBuilder.InsertData("Elenco", new string[] { "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
                new object[] { "Jennifer Joanna Aniston", "Los Angeles, California, U.S.", new DateTime(1969, 02, 11), 0, "Rachel Karen Green", "/imagens/rachelgreen.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
               new object[] { "Courteney Bass Cox", "Birmingham, Alabama, U.S.", new DateTime(1964, 06, 15), 1, "Monica E. Geller", "/imagens/monicageller.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
               new object[] { "Lisa Valerie Kudrow", "Los Angeles, California, U.S.", new DateTime(1963, 07, 30), 1, "Phoebe Buffay", "/imagens/phoebebuffay.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
              new object[] { "Matthew Steven LeBlanc", "Newton, Massachusetts, U.S.", new DateTime(1967, 07, 25), 1, "Joseph Francis Tribbiani Jr.", "/imagens/joeytribiani.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
              new object[] { "David Lawrence Schwimmer", "New York City, U.S.", new DateTime(1966, 11, 02), 1, "Ross Geller,", "/imagens/rossgeller.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
              new object[] { "Matthew Langford Perry", "Williamstown, Massachusetts, U.S.", new DateTime(1969, 08, 19), 0, "Chandler Muriel Bing", "/imagens/chandlerbing.jpg" });

            migrationBuilder.InsertData("CriadoPor", new string[] { "NomeReal", "Nacionalidade", "DatadeNascimento", "CaminhoImagem" },
              new object[] { "Marta Fran Kauffman", "Philadelphia, Pennsylvania, U.S.", new DateTime(1956, 09, 21), "/imagens/martakauffman.jpg" });
            migrationBuilder.InsertData("CriadoPor", new string[] { "NomeReal", "Nacionalidade", "DatadeNascimento", "CaminhoImagem" },
              new object[] { "David Crane", "West New York, New Jersey, U.S.", new DateTime(1957, 08, 13),  "/imagens/davidcrane.jpg" });

            migrationBuilder.InsertData("SeriadoInfo", new string[] { "ResumodaSerie", "Genero", "MusicadeAbertura", "TotaldeTemporadas", "TotaldeEpisodios", "QuandoLancou", "QuandoTerminou" },
              new object[] { "David Crane", "West New York, New Jersey, U.S.", new DateTime(1957, 08, 13), "/imagens/davidcrane.jpg" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Temporadas");
            migrationBuilder.Sql("delete from Elenco");
        }
    }
   
}

