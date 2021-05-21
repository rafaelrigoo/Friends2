using Microsoft.EntityFrameworkCore.Migrations;

namespace Friends.Migrations
{
    public partial class adicionandopropriedadeCaminhoImagem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CaminhoImagem2",
                table: "Elenco",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CaminhoImagem2",
                table: "Criadores",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaminhoImagem2",
                table: "Elenco");

            migrationBuilder.DropColumn(
                name: "CaminhoImagem2",
                table: "Criadores");
        }
    }
}
