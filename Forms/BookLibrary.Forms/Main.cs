using BookLibrary.Forms;
using BookLibrary.Services.Models.User;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Form activeForm;
        private UserListingServiceModel user;

        public Main(UserListingServiceModel user)
        {
            InitializeComponent();
            this.user = user;
            OpenChildForm(new Home(user), null);
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            if (btnSender!=null)
            {
                ActivateButton(btnSender);//  
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(47, 115, 112);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(69, 162, 158);
                }
            }
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account(user), sender);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(user), sender);
        }

        private void MyBooksBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyBooks(user), sender);
        }

        private void FavoritesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Favorites(user), sender);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
