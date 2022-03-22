
namespace BookLibrary.Forms
{
    partial class CreateBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.UploadCoverBtn = new System.Windows.Forms.Button();
            this.UploadPdfBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(342, 12);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(228, 332);
            this.coverPictureBox.TabIndex = 0;
            this.coverPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.descriptionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTxtBox.Location = new System.Drawing.Point(31, 163);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(294, 181);
            this.descriptionTxtBox.TabIndex = 6;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.titleTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTxtBox.Location = new System.Drawing.Point(163, 41);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(162, 23);
            this.titleTxtBox.TabIndex = 7;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.authorTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorTxtBox.Location = new System.Drawing.Point(163, 83);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(162, 23);
            this.authorTxtBox.TabIndex = 8;
            // 
            // UploadCoverBtn
            // 
            this.UploadCoverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.UploadCoverBtn.FlatAppearance.BorderSize = 0;
            this.UploadCoverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadCoverBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UploadCoverBtn.ForeColor = System.Drawing.Color.White;
            this.UploadCoverBtn.Location = new System.Drawing.Point(342, 350);
            this.UploadCoverBtn.Name = "UploadCoverBtn";
            this.UploadCoverBtn.Size = new System.Drawing.Size(228, 49);
            this.UploadCoverBtn.TabIndex = 10;
            this.UploadCoverBtn.Text = "Upload Cover Photo";
            this.UploadCoverBtn.UseVisualStyleBackColor = false;
            // 
            // UploadPdfBtn
            // 
            this.UploadPdfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.UploadPdfBtn.FlatAppearance.BorderSize = 0;
            this.UploadPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadPdfBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UploadPdfBtn.ForeColor = System.Drawing.Color.White;
            this.UploadPdfBtn.Location = new System.Drawing.Point(31, 350);
            this.UploadPdfBtn.Name = "UploadPdfBtn";
            this.UploadPdfBtn.Size = new System.Drawing.Size(134, 49);
            this.UploadPdfBtn.TabIndex = 11;
            this.UploadPdfBtn.Text = "Upload .pdf";
            this.UploadPdfBtn.UseVisualStyleBackColor = false;
            // 
            // CreateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 411);
            this.Controls.Add(this.UploadPdfBtn);
            this.Controls.Add(this.UploadCoverBtn);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coverPictureBox);
            this.Name = "CreateBook";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.Button UploadCoverBtn;
        private System.Windows.Forms.Button UploadPdfBtn;
    }
}

