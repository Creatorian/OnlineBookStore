﻿using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using OnlineBookstore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class PreOrderService : IPreOrderService
    {
        private readonly IPreOrderRepository _preOrderRepository;

        public PreOrderService(IPreOrderRepository preOrderRepository)
        {
            _preOrderRepository = preOrderRepository;
        }
        public void Add(PreOrder preOrder)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByBookId(int bookID)
        {
            throw new NotImplementedException();
        }

        public void DeleteByUserId(string userID)
        {
            throw new NotImplementedException();
        }

        public void Edit(PreOrder preOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PreOrder> GetAllPreOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PreOrder> GetAllPreOrdersByBookId(string bookID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PreOrder> GetAllPreOrdersByUserId(string userID)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PreOrder> GetAllPreOrdersQueryable()
        {
            throw new NotImplementedException();
        }

        public PreOrder GetPreOderByUserId(string userID)
        {
            throw new NotImplementedException();
        }

        public PreOrder GetPreOrderByBookId(int bookID)
        {
            throw new NotImplementedException();
        }

        public PreOrder GetPreOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
