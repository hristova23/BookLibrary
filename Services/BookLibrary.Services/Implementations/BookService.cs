using BookLibrary.Data;
using BookLibrary.Data.Models;
using BookLibrary.Services.Models.Book;
using System;
using System.Collections.Generic;
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

        public Book Create(string title, string description, string PdfUrl, int imageId, int userId)
        {
            if (title == "" 
                || description == ""
                || PdfUrl == "")
            {
                throw new InvalidOperationException("Please, fill all fields");
            }

            Book book = new Book
            {
                Title = title,
                Description = description,
                PdfUrl = PdfUrl,
                ImageId = imageId,
                UserId = userId
            };
            this.data.Books.Add(book);

            this.data.SaveChanges();

            return book;
        }

        public void Delete(int id)
        {
            this.data.Books
                .Remove(this.data.Books
                .Where(b => b.Id == id)
                .FirstOrDefault());

            data.SaveChanges();
        }

        public IEnumerable<BookListingServiceModel> SearchByTitle(string title)
        {
            if (this.data.Books.Any(b => b.Title.ToLower() == title.ToLower()))
            {
                return this.data.Books
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
                    .ToList();
            }
            return null;
        }

        public BookListingServiceModel SearchById(int id)
        {
            return this.data.Books
                .Where(b => b.Id == id)
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

        public Image GetImageById(int id) 
        {
            return this.data.Images.Where(i => i.Id == id).FirstOrDefault();
        }
    }
}
