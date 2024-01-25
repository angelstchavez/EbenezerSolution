using EbenezerSolution.Data.Interface;
using EbenezerSolution.Data.Service;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Business.Controller
{
    public class PersonController : IPersonService
    {
        private readonly PersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }

        public bool Create(Person person)
        {
            return this._personService.Create(person);
        }

        public bool Delete(int id)
        {
            return this._personService.Delete(id);
        }

        public IEnumerable<Person> GetAll()
        {
            return this._personService.GetAll();
        }

        public Person Get(int id)
        {
            return this._personService.Get(id);
        }

        public IEnumerable<Person> Search(string term)
        {
            return this._personService.Search(term);
        }

        public bool Update(Person person)
        {
            return this._personService.Update(person);
        }

        public IEnumerable<Person> GetAllpaginated(int pageSize, int pageNumber)
        {
            return this._personService.GetAllpaginated(pageSize, pageNumber);
        }
    }
}
