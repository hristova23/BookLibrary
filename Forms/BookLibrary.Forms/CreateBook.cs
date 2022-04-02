using BookLibrary.Data;
using BookLibrary.Services.Implementations;
using BookLibrary.Services.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class CreateBook : Form
    {
        private string imagePath;
        private UserListingServiceModel user;

        public CreateBook(UserListingServiceModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UploadCoverBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";

            if (open.ShowDialog() == DialogResult.OK)
            {
                //check id file is jpeg or png...
                imagePath = open.FileName;
                coverPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void CreateBookBtn_Click(object sender, EventArgs e)
        {
            var title = titleTxtBox.Text;
            var description = descriptionTxtBox.Text;
            var pdfUrl = pdfUrlTxtBox.Text;

            try
            {
                using var data = new BookLibraryDbContext();

                var imageService = new ImageService(data);
                var image = imageService.Create(imagePath);

                var bookService = new BookService(data);
                bookService.Create(title, description, pdfUrl, image.Id, user.Id);

                foreach (TextBox txtBox in this.Controls.OfType<TextBox>())
                {
                    txtBox.Clear();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
