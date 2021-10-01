using OnlineBookstore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Repositories.Repositories.Interfaces
{
    interface IorderRepository
    {
        void Add(Order order);
        void Edit(Order order);
        void Delete(int id);
        void DeleteBookById(int bookID);
        void DeleteByUserId(string userID);


        Order GetOrderById(int id);
        Order GetOrderByBookId(int bookID);
        Order GetOrderByUserId(string userID);

        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetAllOrdersByUserId(string userID);
        IEnumerable<Order> GetAllOrdersByBookId(string bookID);
        IQueryable<Order> GetAllOrdersQueryable();
    }
}
