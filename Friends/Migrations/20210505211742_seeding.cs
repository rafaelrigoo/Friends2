using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Friends.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Informacoes", new string[] { "Id","ResumodaSerie", "QuandoLancou", "QuandoTerminou" },
              new object[] {1, "Ross, Rachel, Mônica, Chandler, Joey e Phoebe formam um grupo de seis amigos que lutam para se sobressair e progredir " +
              "na competitiva vida de Manhattan. Seu humor inteligente e apoio mútuo incondicional fazem com sua amizade seja cada vez mais forte," +
              " superando assim todos os obstáculos que a vida lhes apresenta. Trabalho, família, responsabilidade, dinheiro, sexo, compromisso e," +
              " sobretudo, amor e amizade, são alguns dos temas que preocupam e, ás vezes, divertem esses personagens.",new DateTime(1994, 09, 22), new DateTime(2004, 05, 06) });

           
            migrationBuilder.InsertData("Elenco", new string[] { "SeriadoInfoId", "Discriminator", "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
                new object[] {1, "Elenco", "Jennifer Joanna Aniston", "Los Angeles, California, U.S.", new DateTime(1969, 02, 11), 0, "Rachel Karen Green", "/imagens/rachelgreen.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "SeriadoInfoId", "Discriminator", "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
               new object[] {1, "Elenco", "Courteney Bass Cox", "Birmingham, Alabama, U.S.", new DateTime(1964, 06, 15), 1, "Monica E. Geller", "/imagens/monicageller.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "SeriadoInfoId", "Discriminator", "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
               new object[] { 1, "Elenco", "Lisa Valerie Kudrow", "Los Angeles, California, U.S.", new DateTime(1963, 07, 30), 1, "Phoebe Buffay", "/imagens/phoebebuffay.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "SeriadoInfoId", "Discriminator", "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
              new object[] { 1, "Elenco", "Matthew Steven LeBlanc", "Newton, Massachusetts, U.S.", new DateTime(1967, 07, 25), 1, "Joseph Francis Tribbiani Jr.", "/imagens/joeytribiani.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "SeriadoInfoId", "Discriminator", "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
              new object[] { 1, "Elenco", "David Lawrence Schwimmer", "New York City, U.S.", new DateTime(1966, 11, 02), 1, "Ross Geller,", "/imagens/rossgeller.jpg" });
            migrationBuilder.InsertData("Elenco", new string[] { "SeriadoInfoId", "Discriminator", "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem", "CaminhoImagem" },
              new object[] { 1, "Elenco", "Matthew Langford Perry", "Williamstown, Massachusetts, U.S.", new DateTime(1969, 08, 19), 0, "Chandler Muriel Bing", "/imagens/chandlerbing.jpg" });


            migrationBuilder.InsertData("Criadores", new string[] { "SeriadoInfoId", "NomeReal", "Nacionalidade","QuantidadedeFilhos", "DatadeNascimento", "CaminhoImagem" },
              new object[] {1, "Marta Fran Kauffman", "Philadelphia, Pennsylvania, U.S.",0, new DateTime(1956, 09, 21), "/imagens/martakauffman.jpg" });
            migrationBuilder.InsertData("Criadores", new string[] { "SeriadoInfoId", "NomeReal", "Nacionalidade", "QuantidadedeFilhos", "DatadeNascimento", "CaminhoImagem" },
              new object[] {1, "David Crane", "West New York, New Jersey, U.S.",0, new DateTime(1957, 08, 13),  "/imagens/davidcrane.jpg" });

            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("delete from Elenco");
            migrationBuilder.Sql("delete from Informacoes");
           

        }
    }
   
}

