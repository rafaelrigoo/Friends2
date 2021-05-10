using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Friends.Migrations
{
    public partial class seedtemporada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 1,  1, "/imagens/temporada1.jpg", new DateTime(1994, 09, 22), new DateTime(1995, 05, 15) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 2,  2, "/imagens/temporada2.jpg", new DateTime(1995, 09, 21), new DateTime(1996, 05, 16) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 3,  3, "/imagens/temporada3.jpg", new DateTime(1996, 09, 19), new DateTime(1997, 05, 15) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 4,  4, "/imagens/temporada4.jpg", new DateTime(1997, 09, 25), new DateTime(1998, 05, 07) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 5,  5, "/imagens/temporada5.jpg", new DateTime(1998, 09, 24), new DateTime(1999, 05, 20) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 6,  6, "/imagens/temporada6.jpg", new DateTime(1999, 09, 23), new DateTime(2000, 05, 18) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 7,  7, "/imagens/temporada7.jpg", new DateTime(2000, 10, 12), new DateTime(2001, 05, 17) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 8,  8, "/imagens/temporada8.jpg", new DateTime(2001, 09, 27), new DateTime(2002, 05, 16) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 9,  9, "/imagens/temporada9.jpg", new DateTime(2002, 09, 26), new DateTime(2003, 05, 15) });
            migrationBuilder.InsertData("Temporadas", new string[] {"Id", "Numero", "CaminhoImagem", "QuandoFoiLancada", "QuandoTerminou" }, new object[] { 10, 10, "/imagens/temporada10.jpg", new DateTime(2003, 09, 25), new DateTime(2004, 05, 06) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Temporadas");
        }
    }
}
