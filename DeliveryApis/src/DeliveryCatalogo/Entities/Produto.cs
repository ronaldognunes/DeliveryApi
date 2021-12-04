namespace DeliveryCatalogo.Entities
{
    public class Produto
    {
        public Produto(Guid id,string nomeProduto, string descricao,decimal valor, Categoria categoriaProduto)
        {
            Id = id;
            Descricao = descricao;
            CategoriaProduto = categoriaProduto;
            Valor = valor;
            NomeProduto = nomeProduto;
        }
        public Guid Id { get; private set; }
        public string NomeProduto { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public Categoria CategoriaProduto { get; private set; }

    }
}
