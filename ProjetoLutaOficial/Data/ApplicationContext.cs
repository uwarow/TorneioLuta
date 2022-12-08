using Microsoft.EntityFrameworkCore;
using ProjetoLutaOficial.Models;

namespace ProjetoLutaOficial.Data
{
    public class ApplicationContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Database=localhost;Initial Catalog=TorneioLutaOficial7;Integrated Security=SSPI");
            Database.EnsureCreated();   
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lutador>(l =>
            {
                l.ToTable("Lutadores");
                l.HasKey(d => d.Id);
                l.Property(d => d.Nome).HasColumnType("VARCHAR(MAX)").IsRequired();
                l.Property(d => d.Idade).HasColumnType("INT").IsRequired();
                l.Property(d => d.ArtesMarciais).HasColumnType("INT").IsRequired();
                l.Property(d => d.Lutas).HasColumnType("INT").IsRequired();
                l.Property(d => d.Derrotas).HasColumnType("INT").IsRequired();
                l.Property(d => d.Vitorias).HasColumnType("INT").IsRequired();
                l.Property(d => d.Selecionado).HasColumnType("BIT");
            });
        }

        public DbSet<Lutador> Lutadores { get; set; }
    }
}
