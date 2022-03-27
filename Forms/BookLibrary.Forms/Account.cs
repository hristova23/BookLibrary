using BookLibrary.Services.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class Account : Form
    {
        private UserListingServiceModel user;

        public Account(UserListingServiceModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            firstNameTxtBox.Text = user.FirstName;
            lastNameTxtBox.Text = user.LastName;
            emailNameTxtBox.Text = user.Email;

            oldPassTxtBox.Text = "";
            newPassTxtBox.Text = "";
            confirmPassTxtBox.Text = "";

            coverPictureBox.Image = null;
        }

        private void UploadCoverBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                //check id file is jpeg or png...
               var imagePath = open.FileName;
                coverPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account_Load(sender,e);
        }
    }
}
