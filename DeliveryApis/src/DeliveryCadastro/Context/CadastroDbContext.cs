using BuildingBlocks.Repository;
using DeliveryCadastro.Entities;
using DeliveryCadastro.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DeliveryCadastro.Context
{
    public class CadastroDbContext:DbContext,IUnitOfWork
    {
        public DbSet<Usuario>? Usuarios { get; set; }
        public CadastroDbContext( DbContextOptions<CadastroDbContext> options) :base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioMapping).Assembly);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
