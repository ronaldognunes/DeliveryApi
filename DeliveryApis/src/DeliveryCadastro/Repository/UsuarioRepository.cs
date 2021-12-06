using BuildingBlocks.Repository;
using DeliveryCadastro.Context;
using DeliveryCadastro.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeliveryCadastro.Repository
{
    public class UsuarioRepository :IUsuarioRepository
    { 
        private readonly CadastroDbContext _context;
        public IUnitOfWork UnitOfWork => _context;
        public UsuarioRepository(CadastroDbContext contexto)
        {
            _context = contexto;            
        }

        public async Task<Usuario> ConsultarUsuarioPorIdAsync(int id)
        {
            return await _context?.Usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<IEnumerable<Usuario>> RetornarTodosUsuarioAsync()
        {
            return await _context.Usuarios.AsNoTracking().Include(C => C.Endereco).ToListAsync();
        }
        public void AtualizarUsuario(Usuario usuario)
        {
            _context.Usuarios?.Update(usuario);
        }
        public void CadastrarNovoUsuario(Usuario usuario)
        {
            _context.Usuarios?.Add(usuario);
        }        
        public void ExcluirUsuario(Usuario usuario)
        {
            _context.Usuarios?.Remove(usuario);
        }

        
    }
}
