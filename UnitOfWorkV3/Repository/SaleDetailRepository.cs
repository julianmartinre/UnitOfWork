using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkV3.Entities;
using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Repository
{
    public class SaleDetailRepository : Repository, ISaleDetailRepository
    {
        public SaleDetailRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public int Create(ISaleDetail entity)
        {
            var query = "create_saledetail";
            var command = CreateCommand(query);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("idSale", entity.IdSale);
            command.Parameters.AddWithValue("idProduct", entity.Product.Id);
            command.Parameters.AddWithValue("quantity", entity.Quantity);

            return (Int32)command.ExecuteScalar();
        }
    }
}
