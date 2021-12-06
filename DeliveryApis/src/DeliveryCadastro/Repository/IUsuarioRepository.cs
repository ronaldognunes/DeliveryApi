using BuildingBlocks.Repository;
using DeliveryCadastro.Entities;

namespace DeliveryCadastro.Repository
{
    public interface IUsuarioRepository :IRepository<Usuario>
    {
        Task<IEnumerable<Usuario>> RetornarTodosUsuarioAsync();
        Task<Usuario> ConsultarUsuarioPorIdAsync(int id);
        void CadastrarNovoUsuario(Usuario usuario);
        void AtualizarUsuario(Usuario usuario);
        void ExcluirUsuario(Usuario usuario);
    }
}
