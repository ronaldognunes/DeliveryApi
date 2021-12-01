namespace DeliveryPedido.Entities
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public decimal Valor { get; private set; }
        private ICollection<ItemPedido> _itens;

        public IReadOnlyCollection<ItemPedido> itens { get => itens; }

        public Pedido(decimal valor)
        {
            Id = new Guid();
            Valor = valor;
            _itens = new List<ItemPedido>();
        }


        
    }
}
