using Microsoft.EntityFrameworkCore.Migrations;

namespace Friends.Migrations
{
    public partial class alterandocolunaBiografia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Biografia",
                table: "Elenco",
                newName: "ResumoPersonagem");

            migrationBuilder.RenameColumn(
                name: "Biografia",
                table: "Criadores",
                newName: "ResumoPersonagem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResumoPersonagem",
                table: "Elenco",
                newName: "Biografia");

            migrationBuilder.RenameColumn(
                name: "ResumoPersonagem",
                table: "Criadores",
                newName: "Biografia");
        }
    }
}
