using System;
using System.Windows.Forms;
using System.Drawing;

namespace BookLibrary.Forms
{
    public partial class BookListItem : UserControl
    {
        private string author;
        private string title;
        private string imagePath;

        private Form activeForm;

        public BookListItem()
        {
            InitializeComponent();
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Details(title), sender);
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
            this.ParentForm.Controls.Add(childForm);
            this.ParentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
                authorLbl.Text = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                titleLbl.Text = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
                coverPictureBox.Image = new Bitmap(imagePath);
            }
        }
    }
}
