namespace hp2
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txt_box_login_userid = new System.Windows.Forms.TextBox();
            this.txt_box_login_password = new System.Windows.Forms.TextBox();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_cancel_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_box_login_userid
            // 
            this.txt_box_login_userid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_login_userid.Location = new System.Drawing.Point(356, 214);
            this.txt_box_login_userid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_box_login_userid.Name = "txt_box_login_userid";
            this.txt_box_login_userid.Size = new System.Drawing.Size(247, 30);
            this.txt_box_login_userid.TabIndex = 0;
            this.txt_box_login_userid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_box_login_password
            // 
            this.txt_box_login_password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_login_password.Location = new System.Drawing.Point(356, 277);
            this.txt_box_login_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_box_login_password.Name = "txt_box_login_password";
            this.txt_box_login_password.PasswordChar = '*';
            this.txt_box_login_password.Size = new System.Drawing.Size(247, 30);
            this.txt_box_login_password.TabIndex = 1;
            this.txt_box_login_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_logIn
            // 
            this.btn_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logIn.Location = new System.Drawing.Point(512, 387);
            this.btn_logIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(91, 34);
            this.btn_logIn.TabIndex = 3;
            this.btn_logIn.Text = "LOGIN";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            this.btn_logIn.MouseLeave += new System.EventHandler(this.btn_logIn_MouseLeave);
            this.btn_logIn.MouseHover += new System.EventHandler(this.btn_logIn_MouseHover);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(259, 219);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 22);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "User ID :";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_pass.Location = new System.Drawing.Point(237, 277);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(105, 22);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Password :";
            // 
            // btn_cancel_login
            // 
            this.btn_cancel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_login.Location = new System.Drawing.Point(411, 387);
            this.btn_cancel_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel_login.Name = "btn_cancel_login";
            this.btn_cancel_login.Size = new System.Drawing.Size(86, 32);
            this.btn_cancel_login.TabIndex = 13;
            this.btn_cancel_login.Text = "Back";
            this.btn_cancel_login.UseVisualStyleBackColor = true;
            this.btn_cancel_login.Click += new System.EventHandler(this.btn_cancel_login_Click);
            this.btn_cancel_login.MouseLeave += new System.EventHandler(this.btn_cancel_login_MouseLeave);
            this.btn_cancel_login.MouseHover += new System.EventHandler(this.btn_cancel_login_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(426, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 88);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(468, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "forget pasword?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancel_login);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.txt_box_login_password);
            this.Controls.Add(this.txt_box_login_userid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "login";
            this.Size = new System.Drawing.Size(960, 650);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_box_login_userid;
        private System.Windows.Forms.TextBox txt_box_login_password;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_cancel_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
