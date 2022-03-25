using BookLibrary.Data;
using BookLibrary.Data.Models;
using System.Linq;

namespace BookLibrary.Services.Implementations
{
    public class FavoriteBookService : IFavoriteBook
    {
        private readonly BookLibraryDbContext data;

        public FavoriteBookService(BookLibraryDbContext data)
        {
            this.data = data;
        }

        public void Add(int userId, int bookId)
        {
            data.FavoriteBooks.Add(new FavoriteBook
            {
                UserId = userId,
                BookId = bookId
            });
            data.SaveChanges();
        }

        public bool isFavorite(int userId, int bookId)
        {
            foreach (var favBook in data.FavoriteBooks.Where(f=>f.UserId ==userId))
            {
                if (favBook.BookId == bookId)
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(int userId, int bookId)
        {
            data.FavoriteBooks
                .Remove(data.FavoriteBooks
                .Where(b => b.UserId == userId && b.BookId == bookId)
                .FirstOrDefault());

            data.SaveChanges();
        }
    }
}
