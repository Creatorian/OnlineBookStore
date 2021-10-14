using MoreLinq;
using OnlineBookstore.Data;
using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Repositories
{
    public class WishlistRepository : IWishlistRepository
    {
        private readonly DataContext _context;

        public WishlistRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Wishlist wishlist)
        {
            _context.Wishlists.Add(wishlist);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var wishlist = GetWishlistByBookId(id);
            _context.Wishlists.Remove(wishlist);
            _context.SaveChanges();
        }

        public void DeleteByBookId(int bookID)
        {
            var wishlist = GetWishlistByBookId(bookID);
            _context.Wishlists.Remove(wishlist);
            _context.SaveChanges();
        }

        public void Edit(Wishlist wishlist)
        {
            _context.Wishlists.Update(wishlist);
            _context.SaveChanges();
        }

        public IEnumerable<Wishlist> GetAllWishlistByUserId(string userId)
        {
            var result = _context.Wishlists.AsEnumerable().Where(x => x.UserId == userId).DistinctBy(x => x.BookId);
            return result;
        }

        public IEnumerable<Wishlist> GetAllWishlists()
        {
            var result = _context.Wishlists.AsEnumerable();
            return result;
        }

        public Wishlist GetWishlistByBookId(int bookID)
        {
            var result = _context.Wishlists.FirstOrDefault(x => x.BookId == bookID);
            return result;
        }

        public Wishlist GetWishlistById(int id)
        {
            var result = _context.Wishlists.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
