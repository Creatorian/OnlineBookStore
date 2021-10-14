using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using OnlineBookstore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public void DeleteByBookId(int bookID)
        {
            _orderRepository.DeleteBookById(bookID);
        }

        public void DeleteByUserId(string userID)
        {
            _orderRepository.DeleteByUserId(userID);
        }

        public void Edit(Order order)
        {
            _orderRepository.Edit(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrdersByBookId(string bookID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrdersByUserId(string userID)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetAllOrdersQueryable()
        {
            throw new NotImplementedException();
        }

        public Order GetOderByUserId(string userID)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByBookId(int bookID)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
