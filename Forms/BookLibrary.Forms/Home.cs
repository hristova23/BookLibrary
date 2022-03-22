using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class Home : Form
    {
        private Button currentButton;
        private Form activeForm;

        public Home()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);//  
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
            ActivateButton(sender);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void MyBooksBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void FavoritesBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
