using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var listItem = new BookListItem
            {
                Title = "The Flinch",
                Author = "Hristova"
            };
            flowLayoutPanel.Controls.Add(listItem);
        }
    }
}
