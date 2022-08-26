using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Repository
{
    public class UnitOfWorkSqlServer : IUnitOfWork
    {
        private readonly IConfiguration _configuration;

        public UnitOfWorkSqlServer(IConfiguration configuration = null)
        {
            _configuration = configuration;
        }

        public IUnitOfWorkAdapter Create(bool beginTransaction)
        {
            var connectionString = @"Data Source=DESKTOP-0IG0NTD\SQLSERVER2014;Initial Catalog=TCTD;Integrated Security=True";

            return new UnitOfWorkSqlServerAdapter(connectionString, beginTransaction);
        }
    }
}
