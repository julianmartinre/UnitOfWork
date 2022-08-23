using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Repository
{
    public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository
    {
        public IProductRepository ProductRepository { get; }
        public ISaleRepository SaleRepository { get; }
        public ISaleDetailRepository SaleDetailRepository { get; }

        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            ProductRepository = new ProductRepository(context, transaction);
            SaleRepository = new SaleRepository(context, transaction);
            SaleDetailRepository = new SaleDetailRepository(context, transaction);
        }

    }
}
