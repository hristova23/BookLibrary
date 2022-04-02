using BookLibrary.Data;
using BookLibrary.Data.Models;
using BookLibrary.Services.Implementations;
using BookLibrary.Services.Models.Book;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class EditBook : Form
    {
        private BookListingServiceModel book;

        public EditBook(BookListingServiceModel book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            using var data = new BookLibraryDbContext();
            var image = data.Images.Where(i => i.Id == book.ImageId).FirstOrDefault();
            coverPictureBox.Image = new Bitmap(image.Path);
            titleTxtBox.Text = book.Title;
            pdfUrlTxtBox.Text = book.PdfUrl;
            descriptionTxtBox.Text = book.Description;
        }

        private void UploadCoverBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";

            if (open.ShowDialog() == DialogResult.OK)
            {
                //check id file is jpeg or png...
                var imagePath = open.FileName;
                coverPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            var title = titleTxtBox.Text;

            var data = new BookLibraryDbContext();
            var bookService = new BookService(data);
            Book currBook = data.Books.Where(b => b.Title == this.book.Title).FirstOrDefault();

            currBook.Title = title;
            currBook.PdfUrl = pdfUrlTxtBox.Text;
            currBook.Description = descriptionTxtBox.Text;

            data.SaveChanges();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            EditBook_Load(sender,e);
        }
    }
}
