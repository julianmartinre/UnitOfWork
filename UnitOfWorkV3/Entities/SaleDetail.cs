using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Entities
{
    public class SaleDetail : ISaleDetail
    {
        public int IdSale { get; set; } //TODO: refactor.
        public IProduct Product { get; set; }
        public int Quantity { get; set; }

        public SaleDetail() => Product = new Product();
    }
}
