using EbenezerSolution.Data.Interface;
using EbenezerSolution.Data.Service;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Business.Controller
{
    public class UserController : IUserService
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public bool Create(User user)
        {
            return this._userService.Create(user);
        }

        public bool Delete(int id)
        {
            return this._userService.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return this._userService.GetAll();
        }

        public User Get(int id)
        {
            return this._userService.Get(id);
        }

        public IEnumerable<User> Search(string term)
        {
            return this._userService.Search(term);
        }

        public bool Update(User user)
        {
            return this._userService.Update(user);
        }

        public int Count()
        {
            return this._userService.Count();
        }
    }
}
