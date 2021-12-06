namespace BuildingBlocks.Repository
{
    public interface IRepository<T> 
    {
        IUnitOfWork UnitOfWork { get; } 
    }
}
