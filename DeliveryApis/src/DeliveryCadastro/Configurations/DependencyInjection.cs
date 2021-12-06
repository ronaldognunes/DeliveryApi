using DeliveryCadastro.CadastroServices;
using DeliveryCadastro.Context;
using DeliveryCadastro.Repository;

namespace DeliveryCadastro.Configurations
{
    public static class DependencyInjection
    {
        public static void AddRegisterSevices(this IServiceCollection servicos)
        {
            //contexto banco de dados.
            servicos.AddScoped<CadastroDbContext>();
            servicos.AddScoped<IUsuarioRepository, UsuarioRepository>();
            servicos.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
