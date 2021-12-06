namespace BuildingBlocks.Repository
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
