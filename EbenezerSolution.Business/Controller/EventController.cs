using EbenezerSolution.Data.Interface;
using EbenezerSolution.Data.Service;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Business.Controller
{
    public class EventController : IEventService
    {
        private readonly EventService _eventService;

        public EventController()
        {
            this._eventService = new EventService();
        }


        public bool Create(Event @event)
        {
            return this._eventService.Create(@event);
        }

        public bool Delete(int id)
        {
            return this._eventService.Delete(id);
        }

        public IEnumerable<Event> GetAll()
        {
            return this._eventService.GetAll();
        }

        public Event Get(int id)
        {
            return this._eventService.Get(id);
        }

        public IEnumerable<Event> Search(string term)
        {
            return this._eventService.Search(term);
        }

        public bool Update(Event @event)
        {
            return this._eventService.Update(@event);
        }
    }
}
