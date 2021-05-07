using Microsoft.EntityFrameworkCore.Migrations;

namespace Friends.Migrations
{
    public partial class seeddestaque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Destaques", "CaminhoImagem", "/imagens/friendsfundo.jpg");
            migrationBuilder.InsertData("Destaques", "CaminhoImagem", "/imagens/carrosel2.jpg");
            migrationBuilder.InsertData("Destaques", "CaminhoImagem", "/imagens/carrosel3.jpg");
            migrationBuilder.InsertData("Destaques", "CaminhoImagem", "/imagens/imagem-carrosell.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Destaques");
        }
    }
}
