
namespace BookLibrary.Forms
{
    partial class Register
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
            this.LoginLbl = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ShowPassCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.LoginLbl.Location = new System.Drawing.Point(93, 439);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(97, 17);
            this.LoginLbl.TabIndex = 25;
            this.LoginLbl.Text = "Back to LOGIN";
            this.LoginLbl.Click += new System.EventHandler(this.LoginLbl_Click);
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.EmailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTxtBox.Location = new System.Drawing.Point(35, 208);
            this.EmailTxtBox.Multiline = true;
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(216, 28);
            this.EmailTxtBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Already Have an Account?";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(35, 384);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(216, 35);
            this.RegisterBtn.TabIndex = 21;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ShowPassCheckBox
            // 
            this.ShowPassCheckBox.AutoSize = true;
            this.ShowPassCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassCheckBox.Location = new System.Drawing.Point(132, 344);
            this.ShowPassCheckBox.Name = "ShowPassCheckBox";
            this.ShowPassCheckBox.Size = new System.Drawing.Size(119, 21);
            this.ShowPassCheckBox.TabIndex = 20;
            this.ShowPassCheckBox.Text = "Show Password";
            this.ShowPassCheckBox.UseVisualStyleBackColor = true;
            this.ShowPassCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassCheckBox_CheckedChanged);
            // 
            // ConfirmPasswordTxtBox
            // 
            this.ConfirmPasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ConfirmPasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPasswordTxtBox.Location = new System.Drawing.Point(35, 310);
            this.ConfirmPasswordTxtBox.Multiline = true;
            this.ConfirmPasswordTxtBox.Name = "ConfirmPasswordTxtBox";
            this.ConfirmPasswordTxtBox.PasswordChar = '*';
            this.ConfirmPasswordTxtBox.Size = new System.Drawing.Size(216, 28);
            this.ConfirmPasswordTxtBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm Password";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTxtBox.Location = new System.Drawing.Point(35, 259);
            this.PasswordTxtBox.Multiline = true;
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(216, 28);
            this.PasswordTxtBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Register";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.CloseBtn.Location = new System.Drawing.Point(223, 35);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 27);
            this.CloseBtn.TabIndex = 26;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.LastNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameTxtBox.Location = new System.Drawing.Point(35, 157);
            this.LastNameTxtBox.Multiline = true;
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(216, 28);
            this.LastNameTxtBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "LastName";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.FirstNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameTxtBox.Location = new System.Drawing.Point(35, 106);
            this.FirstNameTxtBox.Multiline = true;
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(216, 28);
            this.FirstNameTxtBox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "First Name";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 474);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.ShowPassCheckBox);
            this.Controls.Add(this.ConfirmPasswordTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.CheckBox ShowPassCheckBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label label7;
    }
}