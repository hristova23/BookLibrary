
namespace BookLibrary.Forms
{
    partial class Details
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
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.ViewPdfBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToFavoriteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverPictureBox.Location = new System.Drawing.Point(15, 73);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(231, 362);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 0;
            this.coverPictureBox.TabStop = false;
            // 
            // ViewPdfBtn
            // 
            this.ViewPdfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.ViewPdfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewPdfBtn.FlatAppearance.BorderSize = 0;
            this.ViewPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPdfBtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewPdfBtn.ForeColor = System.Drawing.Color.White;
            this.ViewPdfBtn.Location = new System.Drawing.Point(421, 384);
            this.ViewPdfBtn.Name = "ViewPdfBtn";
            this.ViewPdfBtn.Size = new System.Drawing.Size(135, 51);
            this.ViewPdfBtn.TabIndex = 33;
            this.ViewPdfBtn.Text = "View .pdf";
            this.ViewPdfBtn.UseVisualStyleBackColor = false;
            this.ViewPdfBtn.Click += new System.EventHandler(this.ViewPdfBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.titleLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLbl.Location = new System.Drawing.Point(281, 72);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(114, 48);
            this.titleLbl.TabIndex = 34;
            this.titleLbl.Text = "Title";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.authorLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorLbl.Location = new System.Drawing.Point(290, 120);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(95, 27);
            this.authorLbl.TabIndex = 35;
            this.authorLbl.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(281, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Description:";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTxtBox.Location = new System.Drawing.Point(281, 205);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.ReadOnly = true;
            this.descriptionTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTxtBox.Size = new System.Drawing.Size(275, 173);
            this.descriptionTxtBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(281, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 2);
            this.label2.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 33);
            this.label5.TabIndex = 39;
            this.label5.Text = "Details";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 2);
            this.label3.TabIndex = 41;
            // 
            // AddToFavoriteBtn
            // 
            this.AddToFavoriteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.AddToFavoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToFavoriteBtn.FlatAppearance.BorderSize = 0;
            this.AddToFavoriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToFavoriteBtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToFavoriteBtn.ForeColor = System.Drawing.Color.White;
            this.AddToFavoriteBtn.Location = new System.Drawing.Point(281, 384);
            this.AddToFavoriteBtn.Name = "AddToFavoriteBtn";
            this.AddToFavoriteBtn.Size = new System.Drawing.Size(135, 51);
            this.AddToFavoriteBtn.TabIndex = 42;
            this.AddToFavoriteBtn.Text = "Add to Favorites";
            this.AddToFavoriteBtn.UseVisualStyleBackColor = false;
            this.AddToFavoriteBtn.Click += new System.EventHandler(this.AddToFavoriteBtn_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.AddToFavoriteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.ViewPdfBtn);
            this.Controls.Add(this.coverPictureBox);
            this.MinimumSize = new System.Drawing.Size(598, 489);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Button ViewPdfBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddToFavoriteBtn;
    }
}