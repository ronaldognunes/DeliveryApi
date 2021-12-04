namespace DeliveryCadastro.Entities
{
    public class Endereco
    {
        public Endereco(string? rua, int? numero, string? municipio, string? bairro, string? uf, string? cep, string? complemento)
        {
            Rua = rua;
            Numero = numero;
            Municipio = municipio;
            Bairro = bairro;
            Uf = uf;
            Cep = cep;
            Complemento = complemento;
        }

        public string? Rua { get; set; }
        public int? Numero { get; set; }
        public string? Municipio { get; set; }
        public string? Bairro { get; set; }
        public string? Uf { get; set; }
        public string? Cep { get; set; }
        public string? Complemento { get; set; }

    }
}
