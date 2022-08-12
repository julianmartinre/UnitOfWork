using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Interfaces;

namespace UnitOfWork
{
    public abstract class MsSqlDbContext<T> : ICrud<T> where T: IEntity
    {
        protected IUnitOfWork _uow;
        public abstract void Delete(T entity);
        public abstract IList<T> GetAll();
        public abstract T Save(T entity);
        public abstract T Update(T entity);
    }
}
