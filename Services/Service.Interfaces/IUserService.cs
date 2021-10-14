using OnlineBookstore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services.Service.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int userId);

        IEnumerable<User> GetUsers();
        IQueryable<User> GetUsersQueryable();

        User GetUserById(int userId);
    }
}
