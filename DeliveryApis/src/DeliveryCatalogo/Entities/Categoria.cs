namespace DeliveryCatalogo.Entities
{
    public class Categoria
    {
        public Categoria(Guid id, string descricao, string nomeCategoria) 
        {
            Id = id;
            Descricao = descricao;
            NomeCategoria = nomeCategoria;
   
        }
        public Guid Id { get; private set; }
        public string NomeCategoria { get; private set; }
        public string Descricao { get; private set; }
        
    }

}
