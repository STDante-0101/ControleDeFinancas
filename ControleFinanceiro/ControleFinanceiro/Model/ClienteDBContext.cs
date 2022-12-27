using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Model
{
    public class ClienteDBContext : DbContext
    {
        public ClienteDBContext(DbContextOptions<ClienteDBContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Cliente { get; set; }

    }
}
