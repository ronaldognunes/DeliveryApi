using DeliveryCadastro.Context;
using DeliveryCadastro.Entities;
using DeliveryCadastro.Repository;

namespace DeliveryCadastro.CadastroServices
{
    public class UsuarioService:IUsuarioService
    {
        private readonly CadastroDbContext _context;
        private readonly IUsuarioRepository _repository;

        public UsuarioService(CadastroDbContext context, IUsuarioRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public async Task<bool> AlterarUsuario(int id, Usuario usuario)
        {
            var usuarioDaBase = await _repository.ConsultarUsuarioPorIdAsync(id);
            if (usuarioDaBase != null)
                _repository.AtualizarUsuario(usuario);
            return await _context.Commit();
        }

        public async Task<bool> CadastrarUsuario(Usuario usuario)
        {
            _repository.CadastrarNovoUsuario(usuario);
            return await _context.Commit();
        }

        public async Task<Usuario> ConsultarUsuarioPorId(int id)
        {
            return await _repository.ConsultarUsuarioPorIdAsync(id);
        }

        public async Task<bool> DeletarUsuario(int id)
        {
            var usuarioDaBase = await _repository.ConsultarUsuarioPorIdAsync(id);
            if (usuarioDaBase != null)
                _repository.ExcluirUsuario(usuarioDaBase);

            return await _context.Commit();
        }

        public async Task<IEnumerable<Usuario>> RetornartodosUsuarios()
        {
            return await _repository.RetornarTodosUsuarioAsync();   
        }
    }
}
