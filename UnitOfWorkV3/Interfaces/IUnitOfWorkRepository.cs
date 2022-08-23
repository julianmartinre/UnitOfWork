using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkV3.Interfaces
{
    public interface IUnitOfWorkRepository
    {
        IProductRepository ProductRepository { get; }
        ISaleRepository SaleRepository { get; }
        ISaleDetailRepository SaleDetailRepository { get; }
    }
}
