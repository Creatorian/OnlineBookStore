﻿using MoreLinq;
using OnlineBookstore.Data;
using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly DataContext _context;

        public ShoppingCartRepository(DataContext context)
        {
            _context = context;
        }


        public void Add(ShoppingCart shoppingCart)
        {
            _context.ShoppingCarts.Add(shoppingCart);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shoppingCart = GetShoppingCartById(id);
            _context.ShoppingCarts.Remove(shoppingCart);
            _context.SaveChanges();
        }

        public void DeleteByBookId(int bookID)
        {
            var shoppingCart = GetShoppingCartById(bookID);
            _context.ShoppingCarts.Remove(shoppingCart);
            _context.SaveChanges(); 
        }

        public IEnumerable<ShoppingCart> GetAllItemsInCart()
        {
            var result = _context.ShoppingCarts.AsEnumerable();
            return result;
        }

        public IEnumerable<ShoppingCart> GetAllItemsInCartByUserId(string userId)
        {
            var result = _context.ShoppingCarts.AsEnumerable().Where(x => x.UserId == userId).DistinctBy(x => x.BookId);
            return result;
        }

        public ShoppingCart GetShoppingCartById(int id)
        {
            var result = _context.ShoppingCarts.FirstOrDefault(x => x.Id == id);
            return result;
        }


        public ShoppingCart GetShoppingCartByBookId(int bookID)
        {
            var result = _context.ShoppingCarts.FirstOrDefault(x => x.BookId == bookID);
            return result;
        }
    }
}
