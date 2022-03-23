using System;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class MyBooks : Form
    {
        private Form activeForm;

        public MyBooks()
        {
            InitializeComponent();
        }

        private void MyBooks_Load(object sender, EventArgs e)
        {
            var listItem = new OwnedBookListItem();
            listItem.Title = "The Flinch";
            listItem.Author = "Hristova";
            flowLayoutPanel.Controls.Add(listItem);
        }

        private void CreateBookBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateBook(), sender);
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
