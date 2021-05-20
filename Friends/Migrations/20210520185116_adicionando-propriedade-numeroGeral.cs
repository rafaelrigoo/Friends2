using Microsoft.EntityFrameworkCore.Migrations;

namespace Friends.Migrations
{
    public partial class adicionandopropriedadenumeroGeral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numeroEpisodionaTemporada",
                table: "Episodios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numeroEpisodionoGeral",
                table: "Episodios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numeroEpisodionaTemporada",
                table: "Episodios");

            migrationBuilder.DropColumn(
                name: "numeroEpisodionoGeral",
                table: "Episodios");
        }
    }
}
