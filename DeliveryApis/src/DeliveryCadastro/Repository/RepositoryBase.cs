using DeliveryCadastro.Context;

namespace DeliveryCadastro.Repository
{
    public abstract class RepositoryBase:IRepositoryBase
    {
        private readonly CadastroDbContext _db;
        public RepositoryBase(CadastroDbContext db)
        {
            _db = db;
        }
    }
}
