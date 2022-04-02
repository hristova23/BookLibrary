using BookLibrary.Data;
using BookLibrary.Data.Models;
using BookLibrary.Services.Implementations;
using BookLibrary.Services.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class Favorites : Form
    {
        private UserListingServiceModel user;

        public Favorites(UserListingServiceModel user)
        {
            InitializeComponent();
            this.user = user;
            ShowFavoriteBooks();
        }
        public void ShowFavoriteBooks()
        {
            using var data = new BookLibraryDbContext();

            var favBookService = new FavoriteBookService(data);

            foreach (var book in data.Books)
            {
                if (favBookService.isFavorite(user.Id, book.Id))
                {
                    var imagePath = data.Images.Where(i => i.Id == book.ImageId).FirstOrDefault();
                    var listItem = new BookListItem(user, book, imagePath.Path);
                    flowLayoutPanel.Controls.Add(listItem);
                }
            }
            //foreach (var favBook in data.FavoriteBooks.Where(b=>b.UserId == user.Id).ToList())
            //{
            //    BookService bookService = new BookService(data);
            //    var currBook = bookService.SearchById(favBook.BookId);
            //    var imagePath = data.Images.Where(i => i.Id == currBook.ImageId).FirstOrDefault();
            //    var listItem = new BookListItem(user, currBook.Title, imagePath.Path);
            //    flowLayoutPanel.Controls.Add(listItem);
            //}
        }
    }
}
