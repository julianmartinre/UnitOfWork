using Microsoft.Extensions.Configuration;
using UnitOfWorkV2.Interfaces;

namespace UnitOfWorkV2
{
    public class UnitOfWorkSqlServer : IUnitOfWork
    {
        private readonly IConfiguration _configuration;

        public UnitOfWorkSqlServer(IConfiguration configuration = null)
        {
            _configuration = configuration;
        }

        public IUnitOfWorkAdapter Create()
        {
            var connectionString = @"Data Source=DESKTOP-0IG0NTD\SQLSERVER2014;Initial Catalog=TCTD;Integrated Security=True";

            return new UnitOfWorkSqlServerAdapter(connectionString);
        }
    }
}
