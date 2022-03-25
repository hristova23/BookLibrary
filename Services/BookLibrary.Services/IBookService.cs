using BookLibrary.Data.Models;
using BookLibrary.Services.Models.Book;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface IBookService
    {
        Book Create(string title, string description, string PdfUrl, int imageId, int userId);
        void Delete(int Id);
        IEnumerable<BookListingServiceModel> SearchByTitle(string title);
        BookListingServiceModel SearchById(int id);
    }
}
