using Microsoft.EntityFrameworkCore.Migrations;

namespace Friends.Migrations
{
    public partial class seedcarreirabiografia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biografia",
                table: "Elenco",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Carreira",
                table: "Elenco",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Biografia",
                table: "Criadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Carreira",
                table: "Criadores",
                type: "nvarchar(max)",
                nullable: true);



          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biografia",
                table: "Elenco");

            migrationBuilder.DropColumn(
                name: "Carreira",
                table: "Elenco");

            migrationBuilder.DropColumn(
                name: "Biografia",
                table: "Criadores");

            migrationBuilder.DropColumn(
                name: "Carreira",
                table: "Criadores");
        }
    }
}
