
namespace BookLibrary.Forms
{
    partial class MyBooks
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
            this.CreateBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateBookBtn
            // 
            this.CreateBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.CreateBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBookBtn.FlatAppearance.BorderSize = 0;
            this.CreateBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBookBtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateBookBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBookBtn.Location = new System.Drawing.Point(415, 348);
            this.CreateBookBtn.Name = "CreateBookBtn";
            this.CreateBookBtn.Size = new System.Drawing.Size(155, 51);
            this.CreateBookBtn.TabIndex = 34;
            this.CreateBookBtn.Text = "Create Book";
            this.CreateBookBtn.UseVisualStyleBackColor = false;
            this.CreateBookBtn.Click += new System.EventHandler(this.CreateBookBtn_Click);
            // 
            // MyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 411);
            this.Controls.Add(this.CreateBookBtn);
            this.Name = "MyBooks";
            this.Text = "MyBooks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBookBtn;
    }
}