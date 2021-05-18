using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Friends.Migrations
{
    public partial class seedparticipacaoespecial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Elenco", new string[] { "SeriadoInfoId", "Discriminator", "NomeReal", "Nacionalidade", "DatadeNascimento", "QuantidadedeFilhos", "Personagem"},
               new object[] { 1, "ParticipacaoEspecial", "Maggie Wheeler", "Los Angeles, California, U.S.", new DateTime(1969, 02, 11), 0, " Janice Goralnik" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
