using EbenezerSolution.Data.Generic;
using EbenezerSolution.Entity;
using System;
using System.Collections.Generic;

namespace EbenezerSolution.Data.Interface
{
    public interface IPersonService : IGenericService<Person>
    {
        int CalculateAge(DateTime birthDate);

        IEnumerable<Person> GetAllpaginated(int pageSize, int pageNumber);
    }
}
