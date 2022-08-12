using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Interfaces;

namespace UnitOfWork
{
    public class Application<T> : ICrud<T> where T: IEntity
    {
        ICrud<T> _repository;
        public Application(ICrud<T> repository)
        {
            _repository = repository;
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T Save(T entity)
        {
            return _repository.Save(entity);
        }

        public T Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
