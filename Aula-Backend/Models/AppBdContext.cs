using Microsoft.EntityFrameworkCore;

namespace Aula_Backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Veiculo> Veiculos { get; set; }

       
    }
}
