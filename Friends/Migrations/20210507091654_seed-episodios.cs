using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Friends.Migrations
{
    public partial class seedepisodios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //temporada 1 
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Pilot", 1, new DateTime(1994, 09, 22) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele da Ultrasonografia no Final", 1, new DateTime(1994, 09, 29) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
            new object[] { "Aquele do Dedão", 1, new DateTime(1994, 10, 06) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
            new object[] { "Aquele com George Stephanopoulos", 1, new DateTime(1994, 10, 13) });

            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele com o Sabão em pó da Alemanha Oriental", 1, new DateTime(1994, 10, 20) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Traseiro", 1, new DateTime(1994, 10, 27) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Blecaute", 1, new DateTime(1994, 11, 03) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele em que a Vovó Morre Duas Vezes", 1, new DateTime(1994, 11, 10) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele em que o Underdog Escapa", 1, new DateTime(1994, 11, 17) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Macaco", 1, new DateTime(1994, 12, 15) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele com a Sra. Bing", 1, new DateTime(1995, 01, 05) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele com uma Dúzia de Lasanhas", 1, new DateTime(1995, 01, 12) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele dos Seios", 1, new DateTime(1995, 01, 19) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele dos Corações Doces", 1, new DateTime(1995, 02, 09) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Cara Chapado", 1, new DateTime(1995, 02, 16) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele de Duas Partes: Parte 1", 1, new DateTime(1995, 02, 23) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele de Duas Partes: Parte 2", 1, new DateTime(1995, 02, 23) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Pôquer", 1, new DateTime(1995, 03, 02) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele em que o Macaco Escapa", 1, new DateTime(1995, 03, 09) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Ortodontista Maligno", 1, new DateTime(1995, 04, 06) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele da Monica Falsa", 1, new DateTime(1995, 04, 27) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Fator Repulsa", 1, new DateTime(1995, 05, 04) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Nascimento", 1, new DateTime(1995, 05, 11) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
          new object[] { "Aquele em que Rachel Descobre", 1, new DateTime(1995, 05, 18) });

            //temporada 2
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
            new object[] { "Aquele com a Nova Namorada do Ross", 2, new DateTime(1995, 09, 21) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele do Leite Materno", 2, new DateTime(1995, 09, 28) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele em que Heckles Morre", 2, new DateTime(1995, 10, 05) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele com o Marido da Phoebe", 2, new DateTime(1995, 10, 12) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele com Cinco Bifes e uma Berinjela", 2, new DateTime(1995, 10, 19) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
          new object[] { "Aquele com o Bebê no Ônibus", 2, new DateTime(1995, 11, 02) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
          new object[] { "Aquele em que Ross Descobre", 2, new DateTime(1995, 11, 09) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele com a Lista", 2, new DateTime(1995, 11, 16) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
           new object[] { "Aquele com o Pai da Phoebe", 2, new DateTime(1995, 12, 14) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
          new object[] { "Aquele com o Russ", 2, new DateTime(1996, 01, 04) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
         new object[] { "Aquele com o Casamento Lésbico", 2, new DateTime(1996, 01, 18) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
         new object[] { "Aquele Depois do Superbowl", 2, new DateTime(1996, 01, 28) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
         new object[] { "Aquele com o Vídeo de Formatura", 2, new DateTime(1996, 02, 01) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
         new object[] { "Aquele em que Ross e Rachel... Você Sabe", 2, new DateTime(1996, 02, 08) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
         new object[] { "Aquele em que Joey Sai", 2, new DateTime(1996, 02, 15) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
         new object[] { "Aquele em que Eddie Entra", 2, new DateTime(1996, 02, 22) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
       new object[] { "Aquele em que o Dr. Ramoray Morre", 2, new DateTime(1996, 03, 21) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
          new object[] { "Aquele em que Eddie Não Vai Embora", 2, new DateTime(1996, 03, 28) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
               new object[] { "Aquele em que o Velho Yeller Morre", 2, new DateTime(1996, 04, 04) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele com os Valentões", 2, new DateTime(1996, 04, 25) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
            new object[] { "Aquele com as Duas Festas", 2, new DateTime(1996, 05, 02) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
                new object[] { "Aquele com a Catapora", 2, new DateTime(1996, 05, 09) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
              new object[] { "Aquele com o Casamento de Barry e Mindy", 2, new DateTime(1996, 05, 16) });

            //temporada 3

            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele da Fantasia da Princesa Leia", 3, new DateTime(1996, 09, 19) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele em que Ninguém Está Pronto", 3, new DateTime(1996, 09, 26) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele com a Geleia", 3, new DateTime(1996, 10, 03) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele do Túnel Metafórico", 3, new DateTime(1996, 10, 10) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele do Frank Jr.", 3, new DateTime(1996, 10, 17) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele do Flashback", 3, new DateTime(1996, 10, 31) });

            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
            new object[] { "Aquele com a Cama de Carro de Corrida", 3, new DateTime(1996, 11, 07) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele com o Instrumento para Cutucar", 3, new DateTime(1996, 11, 14) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele do Futebol Americano", 3, new DateTime(1996, 11, 21) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele em que Rachel Pede as Contas", 3, new DateTime(1996, 12, 12) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele em que Chandler Não Lembra Qual Irmã", 3, new DateTime(1997, 01, 09) });

            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele com Todo o Ciúme", 3, new DateTime(1997, 01, 16) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele em que Monica e Richard são Amigos", 3, new DateTime(1997, 01, 30) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele com a ex-Parceira de Phoebe", 3, new DateTime(1997, 02, 06) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele em que Ross e Rachel dão um Tempo", 3, new DateTime(1997, 02, 13) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele da Manhã Seguinte", 3, new DateTime(1997, 02, 20) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele sem a Viagem Para Esquiar", 3, new DateTime(1997, 03, 06) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele com a Fita de Hipnose", 3, new DateTime(1997, 03, 13) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele da Camiseta Minúscula", 3, new DateTime(1997, 03, 27) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele da Casa de Bonecas", 3, new DateTime(1997, 04, 03) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele com o Pintinho e o Pato", 3, new DateTime(1997, 04, 17) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele do Grito", 3, new DateTime(1997, 04, 24) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele da Coisa de Ross", 3, new DateTime(1997, 05, 01) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele com o Campeão de Vale Tudo", 3, new DateTime(1997, 05, 08) });
            migrationBuilder.InsertData("Episodios", new string[] { "Nome", "TemporadaId", "QuandoFoiLancado" },
             new object[] { "Aquele na Praia", 3, new DateTime(1997, 05, 15) });





        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Episodios");
        }
    }
}
