using System.Collections.Generic;

namespace EbenezerSolution.Data.Generic
{
    public interface IGenericService<T> where T : class
    {
        bool Create(T entity);
        bool Delete(int id);
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Search(string term);
        bool Update(T entity);
        int Count();
    }
}
