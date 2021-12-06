
namespace learnIT.DialogForms
{
    partial class JoinClassDialog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textClassCode = new System.Windows.Forms.TextBox();
            this.textClassId = new System.Windows.Forms.TextBox();
            this.labelJoin = new System.Windows.Forms.Label();
            this.labelClassCode = new System.Windows.Forms.Label();
            this.labelClassId = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.errorMessageClassCode = new System.Windows.Forms.Label();
            this.errorMessageClassId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::learnIT.Properties.Resources.JoinClassDialogPic;
            this.pictureBox1.Location = new System.Drawing.Point(35, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textClassCode
            // 
            this.textClassCode.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClassCode.Location = new System.Drawing.Point(288, 109);
            this.textClassCode.Name = "textClassCode";
            this.textClassCode.Size = new System.Drawing.Size(233, 36);
            this.textClassCode.TabIndex = 4;
            // 
            // textClassId
            // 
            this.textClassId.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClassId.Location = new System.Drawing.Point(288, 203);
            this.textClassId.Name = "textClassId";
            this.textClassId.Size = new System.Drawing.Size(233, 36);
            this.textClassId.TabIndex = 5;
            // 
            // labelJoin
            // 
            this.labelJoin.AutoSize = true;
            this.labelJoin.Font = new System.Drawing.Font("Raleway Medium", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.labelJoin.Location = new System.Drawing.Point(216, 9);
            this.labelJoin.Name = "labelJoin";
            this.labelJoin.Size = new System.Drawing.Size(161, 40);
            this.labelJoin.TabIndex = 6;
            this.labelJoin.Text = "Join Class";
            // 
            // labelClassCode
            // 
            this.labelClassCode.AutoSize = true;
            this.labelClassCode.Font = new System.Drawing.Font("Raleway", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.labelClassCode.Location = new System.Drawing.Point(283, 77);
            this.labelClassCode.Name = "labelClassCode";
            this.labelClassCode.Size = new System.Drawing.Size(122, 29);
            this.labelClassCode.TabIndex = 7;
            this.labelClassCode.Text = "Class Code";
            // 
            // labelClassId
            // 
            this.labelClassId.AutoSize = true;
            this.labelClassId.Font = new System.Drawing.Font("Raleway", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.labelClassId.Location = new System.Drawing.Point(283, 171);
            this.labelClassId.Name = "labelClassId";
            this.labelClassId.Size = new System.Drawing.Size(90, 29);
            this.labelClassId.TabIndex = 8;
            this.labelClassId.Text = "Class Id";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Raleway ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(490, 286);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 46);
            this.buttonCancel.TabIndex = 62;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonJoin
            // 
            this.buttonJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.buttonJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJoin.Font = new System.Drawing.Font("Raleway ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJoin.ForeColor = System.Drawing.Color.White;
            this.buttonJoin.Location = new System.Drawing.Point(351, 286);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(113, 46);
            this.buttonJoin.TabIndex = 63;
            this.buttonJoin.Text = "Join";
            this.buttonJoin.UseVisualStyleBackColor = false;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // errorMessageClassCode
            // 
            this.errorMessageClassCode.AutoSize = true;
            this.errorMessageClassCode.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageClassCode.ForeColor = System.Drawing.Color.Red;
            this.errorMessageClassCode.Location = new System.Drawing.Point(411, 84);
            this.errorMessageClassCode.Name = "errorMessageClassCode";
            this.errorMessageClassCode.Size = new System.Drawing.Size(195, 21);
            this.errorMessageClassCode.TabIndex = 64;
            this.errorMessageClassCode.Text = "error message class code";
            // 
            // errorMessageClassId
            // 
            this.errorMessageClassId.AutoSize = true;
            this.errorMessageClassId.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageClassId.ForeColor = System.Drawing.Color.Red;
            this.errorMessageClassId.Location = new System.Drawing.Point(411, 179);
            this.errorMessageClassId.Name = "errorMessageClassId";
            this.errorMessageClassId.Size = new System.Drawing.Size(173, 21);
            this.errorMessageClassId.TabIndex = 65;
            this.errorMessageClassId.Text = "error message class id";
            // 
            // JoinClassDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.errorMessageClassId);
            this.Controls.Add(this.errorMessageClassCode);
            this.Controls.Add(this.buttonJoin);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelClassId);
            this.Controls.Add(this.labelClassCode);
            this.Controls.Add(this.labelJoin);
            this.Controls.Add(this.textClassId);
            this.Controls.Add(this.textClassCode);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JoinClassDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JoinClassDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textClassCode;
        private System.Windows.Forms.TextBox textClassId;
        private System.Windows.Forms.Label labelJoin;
        private System.Windows.Forms.Label labelClassCode;
        private System.Windows.Forms.Label labelClassId;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.Label errorMessageClassCode;
        private System.Windows.Forms.Label errorMessageClassId;
    }
}