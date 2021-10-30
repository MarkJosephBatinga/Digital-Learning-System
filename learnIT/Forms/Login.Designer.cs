
namespace learnIT.Forms
{
    partial class Login
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.errorMessageEmail = new System.Windows.Forms.Label();
            this.errorMessagePassword = new System.Windows.Forms.Label();
            this.errorMessageRole = new System.Windows.Forms.Label();
            this.errorMessageInvalidUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.labelEmail.Location = new System.Drawing.Point(1029, 374);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(70, 29);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.labelPassword.Location = new System.Drawing.Point(1029, 458);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(111, 29);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.White;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRole.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Select a Role",
            "Admin",
            "Student"});
            this.comboBoxRole.Location = new System.Drawing.Point(1117, 302);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(166, 34);
            this.comboBoxRole.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(1034, 406);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(328, 30);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(1034, 489);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(328, 30);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(1079, 535);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(229, 45);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Raleway Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.labelLogin.Location = new System.Drawing.Point(1127, 245);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(148, 52);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "LOG IN";
            // 
            // errorMessageEmail
            // 
            this.errorMessageEmail.AutoSize = true;
            this.errorMessageEmail.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageEmail.ForeColor = System.Drawing.Color.Red;
            this.errorMessageEmail.Location = new System.Drawing.Point(1094, 381);
            this.errorMessageEmail.Name = "errorMessageEmail";
            this.errorMessageEmail.Size = new System.Drawing.Size(160, 21);
            this.errorMessageEmail.TabIndex = 7;
            this.errorMessageEmail.Text = "error message email";
            // 
            // errorMessagePassword
            // 
            this.errorMessagePassword.AutoSize = true;
            this.errorMessagePassword.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessagePassword.ForeColor = System.Drawing.Color.Red;
            this.errorMessagePassword.Location = new System.Drawing.Point(1132, 465);
            this.errorMessagePassword.Name = "errorMessagePassword";
            this.errorMessagePassword.Size = new System.Drawing.Size(190, 21);
            this.errorMessagePassword.TabIndex = 8;
            this.errorMessagePassword.Text = "error message password";
            // 
            // errorMessageRole
            // 
            this.errorMessageRole.AutoSize = true;
            this.errorMessageRole.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageRole.ForeColor = System.Drawing.Color.Red;
            this.errorMessageRole.Location = new System.Drawing.Point(1121, 335);
            this.errorMessageRole.Name = "errorMessageRole";
            this.errorMessageRole.Size = new System.Drawing.Size(148, 21);
            this.errorMessageRole.TabIndex = 9;
            this.errorMessageRole.Text = "error message role";
            // 
            // errorMessageInvalidUser
            // 
            this.errorMessageInvalidUser.AutoSize = true;
            this.errorMessageInvalidUser.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageInvalidUser.ForeColor = System.Drawing.Color.Red;
            this.errorMessageInvalidUser.Location = new System.Drawing.Point(1063, 610);
            this.errorMessageInvalidUser.Name = "errorMessageInvalidUser";
            this.errorMessageInvalidUser.Size = new System.Drawing.Size(271, 21);
            this.errorMessageInvalidUser.TabIndex = 10;
            this.errorMessageInvalidUser.Text = "Invalid Credentials, Please try again";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Raleway", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 860);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::learnIT.Properties.Resources.undraw_secure_login_pdn4;
            this.pictureBox2.Location = new System.Drawing.Point(77, 419);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(567, 399);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway ExtraBold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.label4.Location = new System.Drawing.Point(110, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 66);
            this.label4.TabIndex = 4;
            this.label4.Text = "Meets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway ExtraBold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(110, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 66);
            this.label3.TabIndex = 3;
            this.label3.Text = "And Productivity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway ExtraBold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(110, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "Where Learning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(100, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "learnIT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::learnIT.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.labelRegister.Location = new System.Drawing.Point(995, 640);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(260, 29);
            this.labelRegister.TabIndex = 13;
            this.labelRegister.Text = "Don\'t Have An Account ?";
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRegister.Location = new System.Drawing.Point(1260, 636);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(143, 38);
            this.buttonRegister.TabIndex = 14;
            this.buttonRegister.Text = "Sign Up Here";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorMessageInvalidUser);
            this.Controls.Add(this.errorMessageRole);
            this.Controls.Add(this.errorMessagePassword);
            this.Controls.Add(this.errorMessageEmail);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label errorMessageEmail;
        private System.Windows.Forms.Label errorMessagePassword;
        private System.Windows.Forms.Label errorMessageRole;
        private System.Windows.Forms.Label errorMessageInvalidUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}