
namespace BookLibrary.Forms
{
    partial class BookListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorLbl = new System.Windows.Forms.Label();
            this.DetailsBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLbl
            // 
            this.authorLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLbl.AutoSize = true;
            this.authorLbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.authorLbl.Location = new System.Drawing.Point(3, 157);
            this.authorLbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(100, 15);
            this.authorLbl.TabIndex = 2;
            this.authorLbl.Text = "Author";
            this.authorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.DetailsBtn.FlatAppearance.BorderSize = 0;
            this.DetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DetailsBtn.ForeColor = System.Drawing.Color.White;
            this.DetailsBtn.Location = new System.Drawing.Point(3, 176);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(101, 25);
            this.DetailsBtn.TabIndex = 3;
            this.DetailsBtn.Text = "Details";
            this.DetailsBtn.UseVisualStyleBackColor = false;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.titleLbl.Location = new System.Drawing.Point(3, 140);
            this.titleLbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(100, 17);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Title";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coverPictureBox.Location = new System.Drawing.Point(3, 3);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(101, 134);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 4;
            this.coverPictureBox.TabStop = false;
            // 
            // BookListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.coverPictureBox);
            this.Controls.Add(this.DetailsBtn);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "BookListItem";
            this.Size = new System.Drawing.Size(107, 204);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Button DetailsBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox coverPictureBox;
    }
}
