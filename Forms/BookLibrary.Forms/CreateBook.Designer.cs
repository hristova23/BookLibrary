
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
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UploadCoverBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.CreateBookBtn = new System.Windows.Forms.Button();
            this.pdfUrlTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(558, 2);
            this.label8.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 33);
            this.label5.TabIndex = 43;
            this.label5.Text = "Create Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(276, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // UploadCoverBtn
            // 
            this.UploadCoverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.UploadCoverBtn.FlatAppearance.BorderSize = 0;
            this.UploadCoverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadCoverBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UploadCoverBtn.ForeColor = System.Drawing.Color.White;
            this.UploadCoverBtn.Location = new System.Drawing.Point(22, 385);
            this.UploadCoverBtn.Name = "UploadCoverBtn";
            this.UploadCoverBtn.Size = new System.Drawing.Size(228, 36);
            this.UploadCoverBtn.TabIndex = 10;
            this.UploadCoverBtn.Text = "Upload Cover Photo";
            this.UploadCoverBtn.UseVisualStyleBackColor = false;
            this.UploadCoverBtn.Click += new System.EventHandler(this.UploadCoverBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(276, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.descriptionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTxtBox.Location = new System.Drawing.Point(276, 182);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(294, 174);
            this.descriptionTxtBox.TabIndex = 6;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverPictureBox.Location = new System.Drawing.Point(22, 76);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(228, 280);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 0;
            this.coverPictureBox.TabStop = false;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.titleTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTxtBox.Location = new System.Drawing.Point(408, 85);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(162, 22);
            this.titleTxtBox.TabIndex = 7;
            // 
            // CreateBookBtn
            // 
            this.CreateBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.CreateBookBtn.FlatAppearance.BorderSize = 0;
            this.CreateBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBookBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateBookBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBookBtn.Location = new System.Drawing.Point(276, 385);
            this.CreateBookBtn.Name = "CreateBookBtn";
            this.CreateBookBtn.Size = new System.Drawing.Size(294, 36);
            this.CreateBookBtn.TabIndex = 44;
            this.CreateBookBtn.Text = "Create Book";
            this.CreateBookBtn.UseVisualStyleBackColor = false;
            this.CreateBookBtn.Click += new System.EventHandler(this.CreateBookBtn_Click);
            // 
            // pdfUrlTxtBox
            // 
            this.pdfUrlTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.pdfUrlTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pdfUrlTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pdfUrlTxtBox.Location = new System.Drawing.Point(408, 127);
            this.pdfUrlTxtBox.Name = "pdfUrlTxtBox";
            this.pdfUrlTxtBox.Size = new System.Drawing.Size(162, 22);
            this.pdfUrlTxtBox.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(276, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = ".pdf Url";
            // 
            // CreateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.pdfUrlTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateBookBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UploadCoverBtn);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coverPictureBox);
            this.MinimumSize = new System.Drawing.Size(598, 489);
            this.Name = "CreateBook";
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UploadCoverBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Button CreateBookBtn;
        private System.Windows.Forms.TextBox pdfUrlTxtBox;
        private System.Windows.Forms.Label label4;
    }
}

