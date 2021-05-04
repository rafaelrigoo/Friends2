using Friends.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Dados
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            
        }

        public DbSet<Elenco> Elenco { get; set; }
        public DbSet<CriadoPor> Criadores { get; set; }
        public DbSet<Episodio> Episodios { get; set; }
        public DbSet<Temporada> Temporadas { get; set; }
        public DbSet<Curiosidade> Curiosidades { get; set; }
        public DbSet<Critica> Criticas { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Destaque> Destaques { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<ParticipacaoEspecial> ParticipacoesEspeciais { get; set; }
        public DbSet<SeriadoInfo> Informacoes { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Friends;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Episodio>().HasOne(p => p.Temporada);

        
            modelBuilder.Entity<Temporada>().HasMany(p => p.Episodios);
            modelBuilder.Entity<Temporada>().HasOne(p => p.EpisodioMaisVisto); 

          
        }




    }
}
