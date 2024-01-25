using EbenezerSolution.Data.Interface;
using EbenezerSolution.Data.Service;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Business.Controller
{
    public class ActivityController : IActivityService
    {
        private readonly ActivityService _activityService;

        public ActivityController()
        {
            this._activityService = new ActivityService();
        }

        public bool Create(Activity activity)
        {
            return this._activityService.Create(activity);
        }

        public bool Delete(int id)
        {
            return this._activityService.Delete(id);    
        }

        public IEnumerable<Activity> GelAll()
        {
            return this._activityService.GelAll();
        }

        public Activity Get(int id)
        {
            return this._activityService.Get(id);
        }

        public IEnumerable<Activity> Search(string term)
        {
            return this._activityService.Search(term);
        }

        public bool Update(Activity activity)
        {
            return this._activityService.Update(activity);
        }
    }
}
