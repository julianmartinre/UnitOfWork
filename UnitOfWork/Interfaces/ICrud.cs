using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Interfaces
{
    public interface ICrud<T> where T: IEntity
    {
        T Save(T entity);
        void Delete(T entity);
        IList<T> GetAll();
        T Update(T entity);
    }
}
