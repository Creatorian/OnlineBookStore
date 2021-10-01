using OnlineBookstore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Repositories.Repositories.Interfaces
{
    interface IuserRepository
    {
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int userId);

        IEnumerable<User> GetUsers();
        IQueryable<User> GetUsersQueryable();

        User GetUserById(int userId);   

    }
}
