namespace DeliveryPedido.Entities
{
    public class ItemPedido
    {
        public Guid Id { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal ValorTotal { get; private set; }
    }
}
