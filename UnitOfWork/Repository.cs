using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Interfaces;

namespace UnitOfWork
{
    public abstract class Repository<T> : ICrud<T> where T : IEntity
    {
        protected ICrud<T> _context;
        public Repository(ICrud<T> context)
        {
            _context = context;
        }
        public abstract void Delete(T entity);
        public abstract IList<T> GetAll();
        public abstract T Save(T entity);
        public abstract T Update(T entity);
    }
}
