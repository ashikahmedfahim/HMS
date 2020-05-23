namespace hp2
{
    partial class patient_app_cancel_panel
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
            this.btn_doctor_select = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_patient_ap_delete = new System.Windows.Forms.Button();
            this.cbox_patient_doc_time = new System.Windows.Forms.ComboBox();
            this.cbox_patient_doc_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_p_app_t_c = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_doctor_select
            // 
            this.btn_doctor_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctor_select.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctor_select.ForeColor = System.Drawing.Color.White;
            this.btn_doctor_select.Location = new System.Drawing.Point(681, 339);
            this.btn_doctor_select.Name = "btn_doctor_select";
            this.btn_doctor_select.Size = new System.Drawing.Size(111, 33);
            this.btn_doctor_select.TabIndex = 40;
            this.btn_doctor_select.Text = "Select";
            this.btn_doctor_select.UseVisualStyleBackColor = true;
            this.btn_doctor_select.Click += new System.EventHandler(this.btn_doctor_select_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(211, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Select Date : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 387);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 5, 28, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 5, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(393, 32);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 23, 0, 0, 0, 0);
            // 
            // btn_patient_ap_delete
            // 
            this.btn_patient_ap_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_patient_ap_delete.FlatAppearance.BorderSize = 2;
            this.btn_patient_ap_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_patient_ap_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_ap_delete.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_patient_ap_delete.ForeColor = System.Drawing.Color.White;
            this.btn_patient_ap_delete.Location = new System.Drawing.Point(653, 492);
            this.btn_patient_ap_delete.Name = "btn_patient_ap_delete";
            this.btn_patient_ap_delete.Size = new System.Drawing.Size(139, 46);
            this.btn_patient_ap_delete.TabIndex = 37;
            this.btn_patient_ap_delete.Text = "Confirm";
            this.btn_patient_ap_delete.UseVisualStyleBackColor = true;
            this.btn_patient_ap_delete.Click += new System.EventHandler(this.btn_patient_ap_delete_Click_1);
            // 
            // cbox_patient_doc_time
            // 
            this.cbox_patient_doc_time.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cbox_patient_doc_time.FormattingEnabled = true;
            this.cbox_patient_doc_time.Location = new System.Drawing.Point(399, 439);
            this.cbox_patient_doc_time.Name = "cbox_patient_doc_time";
            this.cbox_patient_doc_time.Size = new System.Drawing.Size(393, 35);
            this.cbox_patient_doc_time.TabIndex = 36;
            // 
            // cbox_patient_doc_name
            // 
            this.cbox_patient_doc_name.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cbox_patient_doc_name.FormattingEnabled = true;
            this.cbox_patient_doc_name.Location = new System.Drawing.Point(399, 289);
            this.cbox_patient_doc_name.Name = "cbox_patient_doc_name";
            this.cbox_patient_doc_name.Size = new System.Drawing.Size(393, 35);
            this.cbox_patient_doc_name.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "Select Time : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Select Doctor Name :";
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(710, 703);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 32);
            this.btn_back.TabIndex = 32;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // lbl_p_app_t_c
            // 
            this.lbl_p_app_t_c.AutoSize = true;
            this.lbl_p_app_t_c.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_app_t_c.ForeColor = System.Drawing.Color.White;
            this.lbl_p_app_t_c.Location = new System.Drawing.Point(326, 49);
            this.lbl_p_app_t_c.Name = "lbl_p_app_t_c";
            this.lbl_p_app_t_c.Size = new System.Drawing.Size(366, 30);
            this.lbl_p_app_t_c.TabIndex = 31;
            this.lbl_p_app_t_c.Text = "Want to Cancel Appiontment";
            // 
            // patient_app_cancel_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btn_doctor_select);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_patient_ap_delete);
            this.Controls.Add(this.cbox_patient_doc_time);
            this.Controls.Add(this.cbox_patient_doc_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_p_app_t_c);
            this.Name = "patient_app_cancel_panel";
            this.Size = new System.Drawing.Size(1011, 800);
            this.Load += new System.EventHandler(this.patient_app_cancel_panel_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doctor_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_patient_ap_delete;
        private System.Windows.Forms.ComboBox cbox_patient_doc_time;
        private System.Windows.Forms.ComboBox cbox_patient_doc_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_p_app_t_c;
    }
}
