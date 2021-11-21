namespace DeliveryCadastro.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class UsuarioDto
    {
        /// <summary>
        /// Nome completo do usuario
        /// </summary>
        public string? NomeCompleto { get; set; }

        /// <summary>
        /// e-mail do usuario 
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// senha usuario
        /// </summary>
        public string? Senha { get; set; }

        public EndereçoDto? Endereco { get; set; }
    }
}
