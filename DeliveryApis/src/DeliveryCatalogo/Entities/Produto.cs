namespace DeliveryCatalogo.Entities
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string NomeProduto { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public Categoria CategoriaProduto { get;private set; }

    }
}
