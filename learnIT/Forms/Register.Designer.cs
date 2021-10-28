
namespace learnIT
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxConPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.errorLabelLastName = new System.Windows.Forms.Label();
            this.errorLabelFirstName = new System.Windows.Forms.Label();
            this.errorLabelEmail = new System.Windows.Forms.Label();
            this.errorLabelPassword = new System.Windows.Forms.Label();
            this.errorLabelConPassword = new System.Windows.Forms.Label();
            this.errorLabelRole = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(418, 301);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(221, 32);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(168, 301);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(225, 32);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(166, 396);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(473, 32);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(166, 492);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(473, 32);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(413, 262);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(122, 25);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(163, 262);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(121, 25);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(163, 368);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(69, 25);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(163, 464);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(112, 25);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(333, 673);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(137, 43);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Sign Up";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxConPassword
            // 
            this.textBoxConPassword.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConPassword.Location = new System.Drawing.Point(166, 600);
            this.textBoxConPassword.Name = "textBoxConPassword";
            this.textBoxConPassword.Size = new System.Drawing.Size(473, 32);
            this.textBoxConPassword.TabIndex = 9;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(163, 560);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(197, 25);
            this.labelConfirmPassword.TabIndex = 10;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.White;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRole.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Select a Role",
            "Admin",
            "Student"});
            this.comboBoxRole.Location = new System.Drawing.Point(322, 185);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(162, 33);
            this.comboBoxRole.TabIndex = 16;
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Raleway", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSignUp.Location = new System.Drawing.Point(326, 141);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(158, 41);
            this.labelSignUp.TabIndex = 18;
            this.labelSignUp.Text = "SIGN UP";
            this.labelSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabelLastName
            // 
            this.errorLabelLastName.AutoSize = true;
            this.errorLabelLastName.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelLastName.ForeColor = System.Drawing.Color.Red;
            this.errorLabelLastName.Location = new System.Drawing.Point(163, 336);
            this.errorLabelLastName.Name = "errorLabelLastName";
            this.errorLabelLastName.Size = new System.Drawing.Size(165, 18);
            this.errorLabelLastName.TabIndex = 19;
            this.errorLabelLastName.Text = "error message lname";
            // 
            // errorLabelFirstName
            // 
            this.errorLabelFirstName.AutoSize = true;
            this.errorLabelFirstName.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelFirstName.ForeColor = System.Drawing.Color.Red;
            this.errorLabelFirstName.Location = new System.Drawing.Point(415, 336);
            this.errorLabelFirstName.Name = "errorLabelFirstName";
            this.errorLabelFirstName.Size = new System.Drawing.Size(166, 18);
            this.errorLabelFirstName.TabIndex = 20;
            this.errorLabelFirstName.Text = "error message fname";
            // 
            // errorLabelEmail
            // 
            this.errorLabelEmail.AutoSize = true;
            this.errorLabelEmail.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelEmail.ForeColor = System.Drawing.Color.Red;
            this.errorLabelEmail.Location = new System.Drawing.Point(163, 431);
            this.errorLabelEmail.Name = "errorLabelEmail";
            this.errorLabelEmail.Size = new System.Drawing.Size(160, 18);
            this.errorLabelEmail.TabIndex = 21;
            this.errorLabelEmail.Text = "error message email";
            // 
            // errorLabelPassword
            // 
            this.errorLabelPassword.AutoSize = true;
            this.errorLabelPassword.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelPassword.ForeColor = System.Drawing.Color.Red;
            this.errorLabelPassword.Location = new System.Drawing.Point(165, 527);
            this.errorLabelPassword.Name = "errorLabelPassword";
            this.errorLabelPassword.Size = new System.Drawing.Size(191, 18);
            this.errorLabelPassword.TabIndex = 22;
            this.errorLabelPassword.Text = "error message password";
            // 
            // errorLabelConPassword
            // 
            this.errorLabelConPassword.AutoSize = true;
            this.errorLabelConPassword.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelConPassword.ForeColor = System.Drawing.Color.Red;
            this.errorLabelConPassword.Location = new System.Drawing.Point(163, 635);
            this.errorLabelConPassword.Name = "errorLabelConPassword";
            this.errorLabelConPassword.Size = new System.Drawing.Size(250, 18);
            this.errorLabelConPassword.TabIndex = 23;
            this.errorLabelConPassword.Text = "error message confirm password";
            // 
            // errorLabelRole
            // 
            this.errorLabelRole.AutoSize = true;
            this.errorLabelRole.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelRole.ForeColor = System.Drawing.Color.Red;
            this.errorLabelRole.Location = new System.Drawing.Point(319, 221);
            this.errorLabelRole.Name = "errorLabelRole";
            this.errorLabelRole.Size = new System.Drawing.Size(148, 18);
            this.errorLabelRole.TabIndex = 24;
            this.errorLabelRole.Text = "error message role";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(830, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 858);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backend Sucks, You need a lot of Caffeine";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::learnIT.Properties.Resources.Open_Doodles___Coffee;
            this.pictureBox1.Location = new System.Drawing.Point(206, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 337);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorLabelRole);
            this.Controls.Add(this.errorLabelConPassword);
            this.Controls.Add(this.errorLabelPassword);
            this.Controls.Add(this.errorLabelEmail);
            this.Controls.Add(this.errorLabelFirstName);
            this.Controls.Add(this.errorLabelLastName);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textBoxConPassword);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "learnIT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelConfirmPassword;
        public System.Windows.Forms.TextBox textBoxFirstName;
        public System.Windows.Forms.TextBox textBoxLastName;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxConPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Label errorLabelLastName;
        private System.Windows.Forms.Label errorLabelFirstName;
        private System.Windows.Forms.Label errorLabelEmail;
        private System.Windows.Forms.Label errorLabelPassword;
        private System.Windows.Forms.Label errorLabelConPassword;
        private System.Windows.Forms.Label errorLabelRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

