using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
    }
}
