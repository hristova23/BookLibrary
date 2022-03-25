using System;
using System.Windows.Forms;
using System.Drawing;
using BookLibrary.Data.Models;
using BookLibrary.Services.Models.User;
using BookLibrary.Services.Models.Book;
using BookLibrary.Services.Implementations;
using BookLibrary.Data;
using System.Linq;

namespace BookLibrary.Forms
{
    public partial class BookListItem : UserControl
    {
        private Form activeForm;
        private UserListingServiceModel user;
        private Book book;

        public BookListItem(UserListingServiceModel user, Book book, string imagePath)
        {
            InitializeComponent();
            this.user = user;
            this.book = book;

            var data = new BookLibraryDbContext();
            var bookService = new BookService(data);
            var authorId = bookService.SearchById(book.Id).UserId;

            var author = data.Users.Where(u=>u.Id == authorId).FirstOrDefault();

            titleLbl.Text = book.Title;
            authorLbl.Text = $"{author.FirstName} {user.LastName}";
            coverPictureBox.Image = new Bitmap(imagePath);
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Details(book.Title,user), sender);
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ParentForm.Controls.Add(childForm);
            this.ParentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
