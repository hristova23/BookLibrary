using BookLibrary.Data;
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
    public partial class Home : Form
    {
        private UserListingServiceModel user;
        public Home(UserListingServiceModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            using var data = new BookLibraryDbContext();

            foreach (var book in data.Books)
            {
                var imagePath = data.Images.Where(i => i.Id == book.ImageId).FirstOrDefault();
                var listItem = new BookListItem(user, book, imagePath.Path);
                flowLayoutPanel.Controls.Add(listItem);
            }
        }
    }
}
