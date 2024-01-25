using EbenezerSolution.Data.Connection;
using EbenezerSolution.Data.Interface;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Data.Service
{
    public class EventService : IEventService
    {
        private string _ConnectionString;

        public EventService()
        {
            this._ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Event entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Event> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Event Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Event> Search(string term)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Event entity)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }
    }
}
