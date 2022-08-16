using System.Data.SqlClient;
using UnitOfWorkV2.Interfaces;

namespace UnitOfWorkV2
{
    public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository
    {
        public IProductRepository ProductRepository { get; }

        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            ProductRepository = new ProductRepository(context, transaction);
        }
    }
}
