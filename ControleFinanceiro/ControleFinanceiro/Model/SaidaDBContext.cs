using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Model
{
    public class SaidaDBContext : DbContext
    {
        public SaidaDBContext(DbContextOptions<SaidaDBContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }

        public DbSet<SaidaReceita> SaidaReceita { get; set; }

    }
}
