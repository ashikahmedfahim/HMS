namespace hp2
{
    partial class patient_appointment_panel
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.btn_cancel_appointment = new System.Windows.Forms.Button();
            this.btn_change_time = new System.Windows.Forms.Button();
            this.btn_patient_ap_submit = new System.Windows.Forms.Button();
            this.cbox_patient_doc_time = new System.Windows.Forms.ComboBox();
            this.cbox_patient_doc_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.label4);
            this.main_panel.Controls.Add(this.dateTimePicker1);
            this.main_panel.Controls.Add(this.btn_cancel_appointment);
            this.main_panel.Controls.Add(this.btn_change_time);
            this.main_panel.Controls.Add(this.btn_patient_ap_submit);
            this.main_panel.Controls.Add(this.cbox_patient_doc_time);
            this.main_panel.Controls.Add(this.cbox_patient_doc_name);
            this.main_panel.Controls.Add(this.label3);
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1007, 763);
            this.main_panel.TabIndex = 10;
            // 
            // btn_cancel_appointment
            // 
            this.btn_cancel_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_appointment.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_cancel_appointment.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_appointment.Location = new System.Drawing.Point(67, 644);
            this.btn_cancel_appointment.Name = "btn_cancel_appointment";
            this.btn_cancel_appointment.Size = new System.Drawing.Size(347, 46);
            this.btn_cancel_appointment.TabIndex = 17;
            this.btn_cancel_appointment.Text = "Cancel Appointment";
            this.btn_cancel_appointment.UseVisualStyleBackColor = true;
            this.btn_cancel_appointment.Click += new System.EventHandler(this.btn_cancel_appointment_Click);
            // 
            // btn_change_time
            // 
            this.btn_change_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_time.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_change_time.ForeColor = System.Drawing.Color.White;
            this.btn_change_time.Location = new System.Drawing.Point(67, 565);
            this.btn_change_time.Name = "btn_change_time";
            this.btn_change_time.Size = new System.Drawing.Size(347, 46);
            this.btn_change_time.TabIndex = 16;
            this.btn_change_time.Text = "Want to Change Timing";
            this.btn_change_time.UseVisualStyleBackColor = true;
            this.btn_change_time.Click += new System.EventHandler(this.btn_change_time_Click_1);
            // 
            // btn_patient_ap_submit
            // 
            this.btn_patient_ap_submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_patient_ap_submit.FlatAppearance.BorderSize = 2;
            this.btn_patient_ap_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_patient_ap_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_ap_submit.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_patient_ap_submit.ForeColor = System.Drawing.Color.White;
            this.btn_patient_ap_submit.Location = new System.Drawing.Point(657, 421);
            this.btn_patient_ap_submit.Name = "btn_patient_ap_submit";
            this.btn_patient_ap_submit.Size = new System.Drawing.Size(139, 46);
            this.btn_patient_ap_submit.TabIndex = 15;
            this.btn_patient_ap_submit.Text = "Submit";
            this.btn_patient_ap_submit.UseVisualStyleBackColor = true;
            // 
            // cbox_patient_doc_time
            // 
            this.cbox_patient_doc_time.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cbox_patient_doc_time.FormattingEnabled = true;
            this.cbox_patient_doc_time.Location = new System.Drawing.Point(403, 301);
            this.cbox_patient_doc_time.Name = "cbox_patient_doc_time";
            this.cbox_patient_doc_time.Size = new System.Drawing.Size(393, 35);
            this.cbox_patient_doc_time.TabIndex = 14;
            // 
            // cbox_patient_doc_name
            // 
            this.cbox_patient_doc_name.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cbox_patient_doc_name.FormattingEnabled = true;
            this.cbox_patient_doc_name.Location = new System.Drawing.Point(403, 241);
            this.cbox_patient_doc_name.Name = "cbox_patient_doc_name";
            this.cbox_patient_doc_name.Size = new System.Drawing.Size(393, 35);
            this.cbox_patient_doc_name.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(215, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Time : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Doctor Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Appointment";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 357);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 5, 28, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 5, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(393, 32);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 21, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select Date : ";
            // 
            // patient_appointment_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.main_panel);
            this.Name = "patient_appointment_panel";
            this.Size = new System.Drawing.Size(1010, 763);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button btn_cancel_appointment;
        private System.Windows.Forms.Button btn_change_time;
        private System.Windows.Forms.Button btn_patient_ap_submit;
        private System.Windows.Forms.ComboBox cbox_patient_doc_time;
        private System.Windows.Forms.ComboBox cbox_patient_doc_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
