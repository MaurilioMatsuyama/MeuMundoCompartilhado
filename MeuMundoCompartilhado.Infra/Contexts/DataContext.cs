using MeuMundoCompartilhado.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeuMundoCompartilhado.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Compromisso> Compromissos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasKey(x => x.Id);
            modelBuilder.Entity<Pessoa>().OwnsOne(x => x.Parentesco, y =>
            {
                y.Property(z => z.Descricao).HasColumnName("ParentescoDescricao");
                y.Property(z => z.Tipo).HasColumnName("ParentescoTipo");
            });

            modelBuilder.Entity<Compromisso>().HasKey(x => x.Id);
            modelBuilder.Entity<Compromisso>().OwnsOne(x => x.Status, y =>
            {
                y.Property(z => z.Descricao).HasColumnName("StatusDescricao");
                y.Property(z => z.Situacao).HasColumnName("StatusSituacao");
            });
        }
    }
}