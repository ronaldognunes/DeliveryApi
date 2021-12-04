﻿namespace DeliveryCadastro.Entities
{
    public class Usuario
    {

        public int? Id { get;  private set ; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Senha { get; private set; }
        public Endereco? Endereco { get; private set; }

        public Usuario(int? id, string nome, string email, string telefone, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void MudarSenha(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
