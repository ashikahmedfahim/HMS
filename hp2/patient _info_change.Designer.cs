namespace hp2
{
    partial class patient__info_change
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_new_address = new System.Windows.Forms.TextBox();
            this.txtxbox_new_phone_no = new System.Windows.Forms.TextBox();
            this.btn_patient_info_change = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter new Phone Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter new Address :";
            // 
            // txtbox_new_address
            // 
            this.txtbox_new_address.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.txtbox_new_address.Location = new System.Drawing.Point(411, 284);
            this.txtbox_new_address.Multiline = true;
            this.txtbox_new_address.Name = "txtbox_new_address";
            this.txtbox_new_address.Size = new System.Drawing.Size(406, 36);
            this.txtbox_new_address.TabIndex = 8;
            // 
            // txtxbox_new_phone_no
            // 
            this.txtxbox_new_phone_no.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.txtxbox_new_phone_no.Location = new System.Drawing.Point(411, 338);
            this.txtxbox_new_phone_no.Name = "txtxbox_new_phone_no";
            this.txtxbox_new_phone_no.Size = new System.Drawing.Size(406, 36);
            this.txtxbox_new_phone_no.TabIndex = 9;
            // 
            // btn_patient_info_change
            // 
            this.btn_patient_info_change.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_patient_info_change.FlatAppearance.BorderSize = 2;
            this.btn_patient_info_change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_patient_info_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_info_change.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_patient_info_change.ForeColor = System.Drawing.Color.White;
            this.btn_patient_info_change.Location = new System.Drawing.Point(678, 400);
            this.btn_patient_info_change.Name = "btn_patient_info_change";
            this.btn_patient_info_change.Size = new System.Drawing.Size(139, 46);
            this.btn_patient_info_change.TabIndex = 19;
            this.btn_patient_info_change.Text = "Confirm";
            this.btn_patient_info_change.UseVisualStyleBackColor = true;
            this.btn_patient_info_change.Click += new System.EventHandler(this.btn_patient_info_change_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(735, 663);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 32);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // patient__info_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_patient_info_change);
            this.Controls.Add(this.txtxbox_new_phone_no);
            this.Controls.Add(this.txtbox_new_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "patient__info_change";
            this.Size = new System.Drawing.Size(1010, 763);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_new_address;
        private System.Windows.Forms.TextBox txtxbox_new_phone_no;
        private System.Windows.Forms.Button btn_patient_info_change;
        private System.Windows.Forms.Button btn_back;
    }
}
