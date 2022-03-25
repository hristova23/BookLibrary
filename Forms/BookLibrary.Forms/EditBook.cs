using BookLibrary.Data;
using BookLibrary.Services.Models.Book;
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
            if (open.ShowDialog() == DialogResult.OK)
            {
                //check id file is jpeg or png...
                coverPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
