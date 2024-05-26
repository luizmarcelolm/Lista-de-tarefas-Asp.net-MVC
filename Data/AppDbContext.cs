using Lista_de_tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Lista_de_tarefas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
            
        public DbSet<Tarefa> tarefas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { CategoriaId = "trabalho", Nome = "Trabalho"},
                 new Categoria { CategoriaId = "casa", Nome = "Casa" },
                  new Categoria { CategoriaId = "faculdade", Nome = "Faculdade" },
                   new Categoria { CategoriaId = "compras", Nome = "Compras" },
                    new Categoria { CategoriaId = "academia", Nome = "Academia" }
                );

            modelBuilder.Entity<Status>().HasData(
               new Status { StatusId = "aberto", Nome = "Aberto" },
                new Status { StatusId = "completo", Nome = "Completo" }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
}
