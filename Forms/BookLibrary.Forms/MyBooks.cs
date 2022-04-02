using System;
using System.Linq;
using System.Windows.Forms;
using BookLibrary.Data;
using BookLibrary.Services.Models.User;

namespace BookLibrary.Forms
{
    public partial class MyBooks : Form
    {
        private UserListingServiceModel user;
        private Form activeForm;

        public MyBooks(UserListingServiceModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void MyBooks_Load(object sender, EventArgs e)
        {
            using var data = new BookLibraryDbContext();

            foreach (var book in data.Books.Where(b=>b.UserId == user.Id))
            {
                var listItem = new OwnedBookListItem(user)
                {
                    Title = book.Title,
                    Author = $"{user.FirstName} {user.LastName}",
                    ImagePath = data.Images.Where(i => i.Id == book.ImageId).FirstOrDefault().Path
                };
                flowLayoutPanel.Controls.Add(listItem);
            }
        }

        private void CreateBookBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateBook(user), sender);
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
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
