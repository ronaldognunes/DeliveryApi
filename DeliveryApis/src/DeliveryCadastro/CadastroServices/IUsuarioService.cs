using DeliveryCadastro.Entities;

namespace DeliveryCadastro.CadastroServices
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> RetornartodosUsuarios();
        Task<Usuario> ConsultarUsuarioPorId(int id);
        Task<bool> CadastrarUsuario(Usuario usuario);
        Task<bool> AlterarUsuario(int id, Usuario usuario);
        Task<bool> DeletarUsuario(int id);
    }
}
