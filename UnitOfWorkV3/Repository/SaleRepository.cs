using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Repository
{
    public class SaleRepository : Repository, ISaleRepository
    {
        public SaleRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public int Create(ISale entity)
        {
            var query = "create_sale";
            var command = CreateCommand(query);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            return (Int32)command.ExecuteScalar();
        }
    }
}
