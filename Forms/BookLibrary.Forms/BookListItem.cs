using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class BookListItem : UserControl
    {
        public BookListItem()
        {
            InitializeComponent();
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {

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
            }
        }
    }
}
