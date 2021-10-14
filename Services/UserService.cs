using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using OnlineBookstore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public void DeleteUser(int userId)
        {
            _userRepository.DeleteUser(userId);
        }

        public void EditUser(User user)
        {
            _userRepository.EditUser(user);
        }

        public User GetUserById(int userId)
        {
            var result = _userRepository.GetUserById(userId);
            return result;
        }

        public IEnumerable<User> GetUsers()
        {
            var result = _userRepository.GetUsers();
            return result;
        }

        public IQueryable<User> GetUsersQueryable()
        {
            var result = _userRepository.GetUsersQueryable();
            return result;
        }
    }
}
