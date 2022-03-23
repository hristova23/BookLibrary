using BookLibrary.Data;
using BookLibrary.Data.Models;
using BookLibrary.Services.Models.Book;
using System;
using System.Linq;

namespace BookLibrary.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly BookLibraryDbContext data;

        public BookService(BookLibraryDbContext data)
        {
            this.data = data;
        }

        public void Create(string title, string description, string PdfUrl, int imageId, int userId)
        {
            if (title == "" 
                || description == ""
                || PdfUrl == "")
            {
                throw new InvalidOperationException("Please, fill all fields");
            }

            this.data.Books.Add(new Book
            {
                Title = title,
                Description = description,
                PdfUrl = PdfUrl,
                ImageId = imageId,
                UserId = userId
            });

            this.data.SaveChanges();
        }

        public void Delete(int id)
        {
            this.data.Books.Remove(this.data.Books.Where(b => b.Id == id).FirstOrDefault());
            data.SaveChanges();
        }

        public BookListingServiceModel SearchByTitle(string title)
        {
            if (this.data.Books.Any(b => b.Title.ToLower() == title.ToLower()))
            {
                return this.data
                    .Books
                    .Where(b => b.Title.ToLower().Contains(title.ToLower()))
                    .Select(b => new BookListingServiceModel
                    {
                        Id = b.Id,
                        Title = b.Title,
                        Description = b.Description,
                        PdfUrl = b.PdfUrl,
                        UserId = b.UserId,
                        ImageId = b.ImageId
                    })
                    .FirstOrDefault();
            }
            return null;
        }
    }
}
