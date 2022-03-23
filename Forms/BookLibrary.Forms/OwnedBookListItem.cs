using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class OwnedBookListItem : UserControl
    {
        public OwnedBookListItem()
        {
            InitializeComponent();
        }
        private string author;
        private string title;
        private Image cover;

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

        public Image Cover
        {
            get
            {
                return cover;
            }
            set
            {
                cover = value;
                coverPictureBox.Image = value;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
