using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entities;

namespace UnitOfWork.Interfaces
{
    public class UserMsSqlDbContext : MsSqlDbContext<User>
    {
        public List<User> users = new List<User>();
        public override void Delete(User entity)
        {
            users.Remove(entity);
        }

        public override IList<User> GetAll()
        {
            return users;
        }

        public override User Save(User entity)
        {
            try
            {
                //_uow.BeginTransaction();
                users.Add(entity);
                //_uow.CommitTransaction();
                return entity;
            }
            catch (Exception ex)
            {
                //_uow.RollBackTransaction();
                throw;
            }    
        }

        public override User Update(User entity)
        {
            return entity;
        }
    }
}
