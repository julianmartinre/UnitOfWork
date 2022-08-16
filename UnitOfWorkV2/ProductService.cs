using UnitOfWorkV2.Interfaces;

namespace UnitOfWorkV2
{
    public interface IProductService
    {
        void Add(Product product);
    }

    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork) { 
            _unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            using (var context = _unitOfWork.Create())
            {
                context.Repositories.ProductRepository.Add(product);

                context.SaveChanges();
            }
        }
    }
}
