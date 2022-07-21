using Microsoft.EntityFrameworkCore;

namespace Curso_MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=MARCOSERVIO\SQLEXPRESS;Database=Cursomvc;Integrated Security=true");
        }
    }
}
