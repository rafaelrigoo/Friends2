﻿// <auto-generated />
using System;
using Friends.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Friends.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Friends.Models.Alternativa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AlternativaCorreta")
                        .HasColumnType("bit");

                    b.Property<string>("OpcaodeResposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Alternativas");
                });

            modelBuilder.Entity("Friends.Models.CriadoPor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaminhoImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carreira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatadeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeReal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadedeFilhos")
                        .HasColumnType("int");

                    b.Property<int?>("SeriadoInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeriadoInfoId");

                    b.ToTable("Criadores");
                });

            modelBuilder.Entity("Friends.Models.Critica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fonte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SeriadoInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeriadoInfoId");

                    b.ToTable("Criticas");
                });

            modelBuilder.Entity("Friends.Models.Curiosidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EpisodioId")
                        .HasColumnType("int");

                    b.Property<int?>("SeriadoInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistaId");

                    b.HasIndex("EpisodioId");

                    b.HasIndex("SeriadoInfoId");

                    b.ToTable("Curiosidades");
                });

            modelBuilder.Entity("Friends.Models.Destaque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaminhoImagem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Destaques");
                });

            modelBuilder.Entity("Friends.Models.Elenco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaminhoImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carreira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatadeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeReal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadedeFilhos")
                        .HasColumnType("int");

                    b.Property<int?>("SeriadoInfoId")
                        .HasColumnType("int");

                    b.Property<int?>("TemporadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeriadoInfoId");

                    b.HasIndex("TemporadaId");

                    b.ToTable("Elenco");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Elenco");
                });

            modelBuilder.Entity("Friends.Models.Episodio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ErrosdeGravacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("QuandoFoiLancado")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sinopse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemporadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TemporadaId");

                    b.ToTable("Episodios");
                });

            modelBuilder.Entity("Friends.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pergunta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quiz");
                });

            modelBuilder.Entity("Friends.Models.SeriadoInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InfoSerie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("QuandoLancou")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("QuandoTerminou")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResumodaSerie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Informacoes");
                });

            modelBuilder.Entity("Friends.Models.Temporada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaminhoImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EpisodioMaisVistoId")
                        .HasColumnType("int");

                    b.Property<byte>("Numero")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("QuandoFoiLancada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("QuandoTerminou")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EpisodioMaisVistoId");

                    b.ToTable("Temporadas");
                });

            modelBuilder.Entity("Friends.Models.ParticipacaoEspecial", b =>
                {
                    b.HasBaseType("Friends.Models.Elenco");

                    b.Property<int?>("QuandoApareceId")
                        .HasColumnType("int");

                    b.Property<int>("QuantosEpisodiosAparece")
                        .HasColumnType("int");

                    b.HasIndex("QuandoApareceId");

                    b.HasDiscriminator().HasValue("ParticipacaoEspecial");
                });

            modelBuilder.Entity("Friends.Models.Alternativa", b =>
                {
                    b.HasOne("Friends.Models.Quiz", null)
                        .WithMany("Alternativas")
                        .HasForeignKey("QuizId");
                });

            modelBuilder.Entity("Friends.Models.CriadoPor", b =>
                {
                    b.HasOne("Friends.Models.SeriadoInfo", null)
                        .WithMany("Criadores")
                        .HasForeignKey("SeriadoInfoId");
                });

            modelBuilder.Entity("Friends.Models.Critica", b =>
                {
                    b.HasOne("Friends.Models.SeriadoInfo", null)
                        .WithMany("Critica")
                        .HasForeignKey("SeriadoInfoId");
                });

            modelBuilder.Entity("Friends.Models.Curiosidade", b =>
                {
                    b.HasOne("Friends.Models.Elenco", "Artista")
                        .WithMany("Curiosidades")
                        .HasForeignKey("ArtistaId");

                    b.HasOne("Friends.Models.Episodio", "Episodio")
                        .WithMany()
                        .HasForeignKey("EpisodioId");

                    b.HasOne("Friends.Models.SeriadoInfo", null)
                        .WithMany("Curiosidade")
                        .HasForeignKey("SeriadoInfoId");

                    b.Navigation("Artista");

                    b.Navigation("Episodio");
                });

            modelBuilder.Entity("Friends.Models.Elenco", b =>
                {
                    b.HasOne("Friends.Models.SeriadoInfo", null)
                        .WithMany("Elenco")
                        .HasForeignKey("SeriadoInfoId");

                    b.HasOne("Friends.Models.Temporada", null)
                        .WithMany("Elenco")
                        .HasForeignKey("TemporadaId");
                });

            modelBuilder.Entity("Friends.Models.Episodio", b =>
                {
                    b.HasOne("Friends.Models.Temporada", "Temporada")
                        .WithMany("Episodios")
                        .HasForeignKey("TemporadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Temporada");
                });

            modelBuilder.Entity("Friends.Models.Temporada", b =>
                {
                    b.HasOne("Friends.Models.Episodio", "EpisodioMaisVisto")
                        .WithMany()
                        .HasForeignKey("EpisodioMaisVistoId");

                    b.Navigation("EpisodioMaisVisto");
                });

            modelBuilder.Entity("Friends.Models.ParticipacaoEspecial", b =>
                {
                    b.HasOne("Friends.Models.Episodio", "QuandoAparece")
                        .WithMany("ParticipacaoEspecial")
                        .HasForeignKey("QuandoApareceId");

                    b.Navigation("QuandoAparece");
                });

            modelBuilder.Entity("Friends.Models.Elenco", b =>
                {
                    b.Navigation("Curiosidades");
                });

            modelBuilder.Entity("Friends.Models.Episodio", b =>
                {
                    b.Navigation("ParticipacaoEspecial");
                });

            modelBuilder.Entity("Friends.Models.Quiz", b =>
                {
                    b.Navigation("Alternativas");
                });

            modelBuilder.Entity("Friends.Models.SeriadoInfo", b =>
                {
                    b.Navigation("Criadores");

                    b.Navigation("Critica");

                    b.Navigation("Curiosidade");

                    b.Navigation("Elenco");
                });

            modelBuilder.Entity("Friends.Models.Temporada", b =>
                {
                    b.Navigation("Elenco");

                    b.Navigation("Episodios");
                });
#pragma warning restore 612, 618
        }
    }
}
