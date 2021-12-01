namespace DeliveryCadastro.Entities
{
    public class Usuario
    {
        public Guid Id { get;  private set ; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string nome, string email, string telefone, string senha)
        {
            Id = Guid.NewGuid();    
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;  
        }

        public void MudarSenha(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
