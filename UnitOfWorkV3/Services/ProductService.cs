using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkV3.Entities;
using UnitOfWorkV3.Interfaces;
using UnitOfWorkV3.Repository;

namespace UnitOfWorkV3.Services
{
    public class ProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateProduct(Product product)
        {
            using (var context = _unitOfWork.Create())
            {
                var result = context.Repositories.ProductRepository.Create(product);

                if (result != 0)
                {
                    context.SaveChanges();
                }
               
                return result;
            }
        }
    }
}
