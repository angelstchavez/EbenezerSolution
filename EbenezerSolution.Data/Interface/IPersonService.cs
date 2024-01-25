using EbenezerSolution.Data.Generic;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Data.Interface
{
    public interface IPersonService : IGenericService<Person>
    {
        IEnumerable<Person> GetAllpaginated(int pageSize, int pageNumber);
    }
}
