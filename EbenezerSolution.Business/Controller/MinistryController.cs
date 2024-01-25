using EbenezerSolution.Data.Interface;
using EbenezerSolution.Data.Service;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Business.Controller
{
    public class MinistryController : IMinistryService
    {
        private readonly MinistryService _ministryService;

        public MinistryController()
        {
            this._ministryService = new MinistryService();
        }

        public bool Create(Ministry ministry)
        {
            return this._ministryService.Create(ministry);
        }

        public bool Delete(int id)
        {
            return this._ministryService.Delete(id);
        }

        public IEnumerable<Ministry> GetAll()
        {
            return this._ministryService.GetAll();
        }

        public Ministry Get(int id)
        {
            return this._ministryService.Get(id);
        }

        public IEnumerable<Ministry> Search(string term)
        {
            return this._ministryService.Search(term);
        }

        public bool Update(Ministry ministry)
        {
            return this._ministryService.Update(ministry);
        }

        public int Count()
        {
            return this._ministryService.Count();
        }
    }
}
