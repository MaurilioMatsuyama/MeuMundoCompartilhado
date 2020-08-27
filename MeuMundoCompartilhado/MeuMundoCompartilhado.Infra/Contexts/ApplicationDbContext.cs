using MeuMundoCompartilhado.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace MeuMundoCompartilhado.Infra.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Compromisso> Compromissos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasKey(x => x.Id);
            modelBuilder.Entity<Compromisso>().HasKey(x => x.Id);
        }
    }
}