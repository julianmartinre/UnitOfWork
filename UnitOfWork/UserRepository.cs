using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entities;
using UnitOfWork.Interfaces;

namespace UnitOfWork
{
    public class UserRepository : Repository<User>
    {
        public UserRepository() : base(new UserMsSqlDbContext())
        {

        }

        public override void Delete(User entity)
        {
            _context.Delete(entity);
        }

        public override IList<User> GetAll()
        {
            return _context.GetAll();
        }

        public override User Save(User entity)
        {
            return _context.Save(entity);
        }

        public override User Update(User entity)
        {
            return _context.Update(entity);
        }
    }
}
