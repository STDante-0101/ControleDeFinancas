using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Model
{
    public class EntradaDBContext : DbContext
    {
        public EntradaDBContext(DbContextOptions<EntradaDBContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }

        public DbSet<EntradaReceita> EntradaReceita { get; set; }

    }
}
