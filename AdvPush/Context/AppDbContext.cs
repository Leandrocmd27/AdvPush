using AdvPush.Domain;
using Microsoft.EntityFrameworkCore;

namespace AdvPush.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {}

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Processo>? Processos { get; set; }
    }
}
