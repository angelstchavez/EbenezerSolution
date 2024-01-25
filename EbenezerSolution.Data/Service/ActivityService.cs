using EbenezerSolution.Data.Connection;
using EbenezerSolution.Data.Interface;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Data.Service
{
    public class ActivityService : IActivityService
    {
        private string _ConectionString;

        public ActivityService()
        {
            _ConectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Activity entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Activity> GelAll()
        {
            throw new System.NotImplementedException();
        }

        public Activity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Activity> Search(string term)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Activity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
