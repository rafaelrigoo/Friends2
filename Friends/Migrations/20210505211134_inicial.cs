using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Friends.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destaques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destaques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Informacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumodaSerie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuandoLancou = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuandoTerminou = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pergunta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Criadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriadoInfoId = table.Column<int>(type: "int", nullable: true),
                    NomeReal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatadeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadedeFilhos = table.Column<int>(type: "int", nullable: false),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criadores_Informacoes_SeriadoInfoId",
                        column: x => x.SeriadoInfoId,
                        principalTable: "Informacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Criticas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fonte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriadoInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criticas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criticas_Informacoes_SeriadoInfoId",
                        column: x => x.SeriadoInfoId,
                        principalTable: "Informacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alternativas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpcaodeResposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativaCorreta = table.Column<bool>(type: "bit", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alternativas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alternativas_Quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Curiosidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistaId = table.Column<int>(type: "int", nullable: true),
                    EpisodioId = table.Column<int>(type: "int", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeriadoInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curiosidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curiosidades_Informacoes_SeriadoInfoId",
                        column: x => x.SeriadoInfoId,
                        principalTable: "Informacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Elenco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeriadoInfoId = table.Column<int>(type: "int", nullable: true),
                    TemporadaId = table.Column<int>(type: "int", nullable: true),
                    QuandoApareceId = table.Column<int>(type: "int", nullable: true),
                    QuantosEpisodiosAparece = table.Column<int>(type: "int", nullable: true),
                    NomeReal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatadeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadedeFilhos = table.Column<int>(type: "int", nullable: false),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elenco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elenco_Informacoes_SeriadoInfoId",
                        column: x => x.SeriadoInfoId,
                        principalTable: "Informacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Temporadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    QuandoFoiLancada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuandoTerminou = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EpisodioMaisVistoId = table.Column<int>(type: "int", nullable: true),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temporadas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Episodios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemporadaId = table.Column<int>(type: "int", nullable: false),
                    QuandoFoiLancado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ErrosdeGravacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinopse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodios_Temporadas_TemporadaId",
                        column: x => x.TemporadaId,
                        principalTable: "Temporadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alternativas_QuizId",
                table: "Alternativas",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Criadores_SeriadoInfoId",
                table: "Criadores",
                column: "SeriadoInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Criticas_SeriadoInfoId",
                table: "Criticas",
                column: "SeriadoInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Curiosidades_ArtistaId",
                table: "Curiosidades",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Curiosidades_EpisodioId",
                table: "Curiosidades",
                column: "EpisodioId");

            migrationBuilder.CreateIndex(
                name: "IX_Curiosidades_SeriadoInfoId",
                table: "Curiosidades",
                column: "SeriadoInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_QuandoApareceId",
                table: "Elenco",
                column: "QuandoApareceId");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_SeriadoInfoId",
                table: "Elenco",
                column: "SeriadoInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_TemporadaId",
                table: "Elenco",
                column: "TemporadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodios_TemporadaId",
                table: "Episodios",
                column: "TemporadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Temporadas_EpisodioMaisVistoId",
                table: "Temporadas",
                column: "EpisodioMaisVistoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curiosidades_Elenco_ArtistaId",
                table: "Curiosidades",
                column: "ArtistaId",
                principalTable: "Elenco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Curiosidades_Episodios_EpisodioId",
                table: "Curiosidades",
                column: "EpisodioId",
                principalTable: "Episodios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Elenco_Episodios_QuandoApareceId",
                table: "Elenco",
                column: "QuandoApareceId",
                principalTable: "Episodios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Elenco_Temporadas_TemporadaId",
                table: "Elenco",
                column: "TemporadaId",
                principalTable: "Temporadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Temporadas_Episodios_EpisodioMaisVistoId",
                table: "Temporadas",
                column: "EpisodioMaisVistoId",
                principalTable: "Episodios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Temporadas_Episodios_EpisodioMaisVistoId",
                table: "Temporadas");

            migrationBuilder.DropTable(
                name: "Alternativas");

            migrationBuilder.DropTable(
                name: "Criadores");

            migrationBuilder.DropTable(
                name: "Criticas");

            migrationBuilder.DropTable(
                name: "Curiosidades");

            migrationBuilder.DropTable(
                name: "Destaques");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "Elenco");

            migrationBuilder.DropTable(
                name: "Informacoes");

            migrationBuilder.DropTable(
                name: "Episodios");

            migrationBuilder.DropTable(
                name: "Temporadas");
        }
    }
}
