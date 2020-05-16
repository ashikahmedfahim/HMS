namespace hp2
{
    partial class signup
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
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_user_id = new System.Windows.Forms.Label();
            this.txt_box_name = new System.Windows.Forms.TextBox();
            this.txt_box_userid = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_box_password = new System.Windows.Forms.TextBox();
            this.txt_box_phone = new System.Windows.Forms.TextBox();
            this.txt_box_address = new System.Windows.Forms.TextBox();
            this.btn_cancel_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(797, 414);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(86, 32);
            this.btn_signup.TabIndex = 0;
            this.btn_signup.Text = "SIGNUP";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            this.btn_signup.MouseLeave += new System.EventHandler(this.btn_signup_MouseLeave);
            this.btn_signup.MouseHover += new System.EventHandler(this.btn_signup_MouseHover);
            // 
            // lbl_user_id
            // 
            this.lbl_user_id.AutoSize = true;
            this.lbl_user_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_id.ForeColor = System.Drawing.Color.White;
            this.lbl_user_id.Location = new System.Drawing.Point(448, 81);
            this.lbl_user_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user_id.Name = "lbl_user_id";
            this.lbl_user_id.Size = new System.Drawing.Size(98, 26);
            this.lbl_user_id.TabIndex = 1;
            this.lbl_user_id.Text = "User ID :";
            this.lbl_user_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_box_name
            // 
            this.txt_box_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_name.Location = new System.Drawing.Point(567, 150);
            this.txt_box_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_box_name.Name = "txt_box_name";
            this.txt_box_name.Size = new System.Drawing.Size(318, 30);
            this.txt_box_name.TabIndex = 2;
            this.txt_box_name.TextChanged += new System.EventHandler(this.txt_box_name_TextChanged);
            // 
            // txt_box_userid
            // 
            this.txt_box_userid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_userid.Location = new System.Drawing.Point(567, 78);
            this.txt_box_userid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_box_userid.Name = "txt_box_userid";
            this.txt_box_userid.Size = new System.Drawing.Size(318, 30);
            this.txt_box_userid.TabIndex = 3;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(462, 153);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(83, 26);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(564, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Please use p as first character(like p1234)";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(425, 224);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(120, 26);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password :";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.White;
            this.lbl_phone.Location = new System.Drawing.Point(456, 293);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(87, 26);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Phone :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.White;
            this.lbl_address.Location = new System.Drawing.Point(440, 362);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(104, 26);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "Address :";
            // 
            // txt_box_password
            // 
            this.txt_box_password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_password.Location = new System.Drawing.Point(567, 221);
            this.txt_box_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_box_password.Name = "txt_box_password";
            this.txt_box_password.Size = new System.Drawing.Size(318, 30);
            this.txt_box_password.TabIndex = 9;
            // 
            // txt_box_phone
            // 
            this.txt_box_phone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_phone.Location = new System.Drawing.Point(567, 290);
            this.txt_box_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_box_phone.Name = "txt_box_phone";
            this.txt_box_phone.Size = new System.Drawing.Size(318, 30);
            this.txt_box_phone.TabIndex = 10;
            // 
            // txt_box_address
            // 
            this.txt_box_address.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_address.Location = new System.Drawing.Point(567, 359);
            this.txt_box_address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_box_address.Name = "txt_box_address";
            this.txt_box_address.Size = new System.Drawing.Size(318, 30);
            this.txt_box_address.TabIndex = 11;
            // 
            // btn_cancel_signup
            // 
            this.btn_cancel_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_signup.Location = new System.Drawing.Point(697, 414);
            this.btn_cancel_signup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel_signup.Name = "btn_cancel_signup";
            this.btn_cancel_signup.Size = new System.Drawing.Size(86, 32);
            this.btn_cancel_signup.TabIndex = 12;
            this.btn_cancel_signup.Text = "Cancel";
            this.btn_cancel_signup.UseVisualStyleBackColor = true;
            this.btn_cancel_signup.Click += new System.EventHandler(this.btn_cancel_signup_Click);
            this.btn_cancel_signup.MouseLeave += new System.EventHandler(this.btn_cancel_signup_MouseLeave);
            this.btn_cancel_signup.MouseHover += new System.EventHandler(this.btn_cancel_signup_MouseHover);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btn_cancel_signup);
            this.Controls.Add(this.txt_box_address);
            this.Controls.Add(this.txt_box_phone);
            this.Controls.Add(this.txt_box_password);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_box_userid);
            this.Controls.Add(this.txt_box_name);
            this.Controls.Add(this.lbl_user_id);
            this.Controls.Add(this.btn_signup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signup";
            this.Size = new System.Drawing.Size(960, 620);
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_user_id;
        private System.Windows.Forms.TextBox txt_box_name;
        private System.Windows.Forms.TextBox txt_box_userid;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_box_password;
        private System.Windows.Forms.TextBox txt_box_phone;
        private System.Windows.Forms.TextBox txt_box_address;
        private System.Windows.Forms.Button btn_cancel_signup;
    }
}
