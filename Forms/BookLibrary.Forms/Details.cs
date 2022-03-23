using BookLibrary.Data;
using BookLibrary.Services.Implementations;
using BookLibrary.Services.Models.Book;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class Details : Form
    {
        private BookLibraryDbContext data = new BookLibraryDbContext();
        private BookListingServiceModel book;

        public Details(string title)
        {
            var bookService = new BookService(data);
            book = bookService.SearchByTitle(title);

            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            var user = data.Users.Where(u => u.Id == book.UserId).FirstOrDefault();
            titleLbl.Text = book.Title;
            authorLbl.Text = $"{user.FirstName} {user.LastName}";
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
    }
}
