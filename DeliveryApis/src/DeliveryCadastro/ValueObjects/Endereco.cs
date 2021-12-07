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

        public string? Rua { get; private set; }
        public int? Numero { get; private set; }
        public string? Municipio { get; private set; }
        public string? Bairro { get; private set; }
        public string? Uf { get; private set; }
        public string? Cep { get; private set; }
        public string? Complemento { get; private set; }

    }
}
