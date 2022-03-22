
namespace BookLibrary
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.FavoritesBtn = new System.Windows.Forms.Button();
            this.MyBooksBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.panelMenu.Controls.Add(this.LogOutBtn);
            this.panelMenu.Controls.Add(this.FavoritesBtn);
            this.panelMenu.Controls.Add(this.MyBooksBtn);
            this.panelMenu.Controls.Add(this.SearchBtn);
            this.panelMenu.Controls.Add(this.AccountBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(202, 450);
            this.panelMenu.TabIndex = 2;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Location = new System.Drawing.Point(0, 400);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(202, 50);
            this.LogOutBtn.TabIndex = 5;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // FavoritesBtn
            // 
            this.FavoritesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FavoritesBtn.FlatAppearance.BorderSize = 0;
            this.FavoritesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.FavoritesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.FavoritesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavoritesBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FavoritesBtn.ForeColor = System.Drawing.Color.White;
            this.FavoritesBtn.Image = ((System.Drawing.Image)(resources.GetObject("FavoritesBtn.Image")));
            this.FavoritesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoritesBtn.Location = new System.Drawing.Point(0, 308);
            this.FavoritesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FavoritesBtn.Name = "FavoritesBtn";
            this.FavoritesBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.FavoritesBtn.Size = new System.Drawing.Size(202, 60);
            this.FavoritesBtn.TabIndex = 4;
            this.FavoritesBtn.Text = " Favorites";
            this.FavoritesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FavoritesBtn.UseVisualStyleBackColor = true;
            this.FavoritesBtn.Click += new System.EventHandler(this.FavoritesBtn_Click);
            // 
            // MyBooksBtn
            // 
            this.MyBooksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyBooksBtn.FlatAppearance.BorderSize = 0;
            this.MyBooksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.MyBooksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.MyBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyBooksBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MyBooksBtn.ForeColor = System.Drawing.Color.White;
            this.MyBooksBtn.Image = ((System.Drawing.Image)(resources.GetObject("MyBooksBtn.Image")));
            this.MyBooksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyBooksBtn.Location = new System.Drawing.Point(0, 248);
            this.MyBooksBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MyBooksBtn.Name = "MyBooksBtn";
            this.MyBooksBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.MyBooksBtn.Size = new System.Drawing.Size(202, 60);
            this.MyBooksBtn.TabIndex = 3;
            this.MyBooksBtn.Text = " My Books";
            this.MyBooksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MyBooksBtn.UseVisualStyleBackColor = true;
            this.MyBooksBtn.Click += new System.EventHandler(this.MyBooksBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(0, 188);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.SearchBtn.Size = new System.Drawing.Size(202, 60);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = " Search";
            this.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AccountBtn
            // 
            this.AccountBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountBtn.FlatAppearance.BorderSize = 0;
            this.AccountBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.AccountBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBtn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountBtn.ForeColor = System.Drawing.Color.White;
            this.AccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("AccountBtn.Image")));
            this.AccountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountBtn.Location = new System.Drawing.Point(0, 128);
            this.AccountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.AccountBtn.Size = new System.Drawing.Size(202, 60);
            this.AccountBtn.TabIndex = 1;
            this.AccountBtn.Text = " Account";
            this.AccountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountBtn.UseVisualStyleBackColor = true;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(202, 128);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(202, 0);
            this.panelDesktopPane.MinimumSize = new System.Drawing.Size(598, 450);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(598, 450);
            this.panelDesktopPane.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main";
            this.Text = "Home";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button FavoritesBtn;
        private System.Windows.Forms.Button MyBooksBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}