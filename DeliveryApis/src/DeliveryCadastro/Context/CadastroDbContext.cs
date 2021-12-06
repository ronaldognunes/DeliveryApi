using DeliveryCadastro.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeliveryCadastro.Context
{
    public class CadastroDbContext:DbContext
    {
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Endereco>? Enderecos { get; set; }
        public CadastroDbContext( DbContextOptions<CadastroDbContext> options) :base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
