namespace UnitOfWorkV2.Interfaces
{
    public interface IUnitOfWorkRepository
    {
        IProductRepository ProductRepository { get; }
    }
}
