using BookLibrary.Data;
using BookLibrary.Data.Models;
using BookLibrary.Services.Implementations;
using BookLibrary.Services.Models.Book;
using BookLibrary.Services.Models.User;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class Details : Form
    {
        private BookLibraryDbContext data = new BookLibraryDbContext();
        private FavoriteBookService favBookService;
        private BookListingServiceModel book;
        private UserListingServiceModel user;

        public Details(string title, UserListingServiceModel user)
        {
            var bookService = new BookService(data);
            this.book = bookService.SearchByTitle(title).FirstOrDefault();
            this.user = user;
            favBookService = new FavoriteBookService(data);
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            if (favBookService.isFavorite(user.Id,book.Id))
            {
                AddToFavoriteBtn.Text = "Remove from Favorites";
            }
            var author = data.Users.Where(u => u.Id == book.UserId).FirstOrDefault();
            titleLbl.Text = book.Title;
            authorLbl.Text = $"{author.FirstName} {author.LastName}";
            descriptionTxtBox.Text = book.Description;
            coverPictureBox.Image = new Bitmap(data.Images.Where(i=>i.Id == book.ImageId).FirstOrDefault().Path);
        }

        private void ViewPdfBtn_Click(object sender, EventArgs e)
        {
            var uri = book.PdfUrl;
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void AddToFavoriteBtn_Click(object sender, EventArgs e)
        {
            if (AddToFavoriteBtn.Text == "Add to Favorites")
            {
                favBookService.Add(user.Id, book.Id);
                AddToFavoriteBtn.Text = "Remove from Favorites";
            }
            else
            {
                favBookService.Remove(user.Id, book.Id);
                AddToFavoriteBtn.Text = "Add to Favorites";
            }
        }
    }
}
