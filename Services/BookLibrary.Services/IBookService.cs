using BookLibrary.Data.Models;

namespace BookLibrary.Services
{
    public interface IBookService
    {
        void Create(string title, string description, string PdfUrl, int imageId, int userId);
        void Delete(int Id);
        //IEnumerable<BookListingServiceModel> SearchByTitle(string name);
    }
}
