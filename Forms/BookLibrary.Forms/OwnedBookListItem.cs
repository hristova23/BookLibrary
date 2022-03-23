using System;
using System.Windows.Forms;
using System.Drawing;
using BookLibrary.Data;
using System.Linq;
using BookLibrary.Services.Implementations;

namespace BookLibrary.Forms
{
    public partial class OwnedBookListItem : UserControl
    {
        private string author;
        private string title;
        private string imagePath;
        
        private Form activeForm;

        public OwnedBookListItem()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            using var data = new BookLibraryDbContext();
            var bookService = new BookService(data);
            var book = bookService.SearchByTitle(this.title);
            OpenChildForm(new EditBook(book),sender);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using var data = new BookLibraryDbContext();

            var bookService = new BookService(data);
            int bookId = data.Books.Where(b => b.Title.ToLower() == this.title.ToLower()).FirstOrDefault().Id;
            bookService.Delete(bookId);
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
