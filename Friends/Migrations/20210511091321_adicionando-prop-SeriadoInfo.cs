using Microsoft.EntityFrameworkCore.Migrations;

namespace Friends.Migrations
{
    public partial class adicionandopropSeriadoInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InfoSerie",
                table: "Informacoes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InfoSerie",
                table: "Informacoes");
        }
    }
}
