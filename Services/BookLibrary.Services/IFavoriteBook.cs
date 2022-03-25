namespace BookLibrary.Services
{
    public interface IFavoriteBook
    {
        void Add(int userId, int bookId);
        void Remove(int userId, int bookId);
        bool isFavorite(int userId, int bookId);
    }
}
