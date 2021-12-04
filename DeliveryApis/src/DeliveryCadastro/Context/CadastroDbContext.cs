using DeliveryCadastro.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeliveryCadastro.Context
{
    public class CadastroDbContext:DbContext
    {
        public CadastroDbContext( DbContextOptions options) :base(options)
        {
            DbSet<Usuario> Usuarios;
            DbSet<Endereco> Enderecos;
        }
    }
}
