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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_patient_doc_name = new System.Windows.Forms.ComboBox();
            this.cbox_patient_doc_time = new System.Windows.Forms.ComboBox();
            this.btn_patient_ap_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Doctor Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Time : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Want to Change Timing";
            // 
            // cbox_patient_doc_name
            // 
            this.cbox_patient_doc_name.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cbox_patient_doc_name.FormattingEnabled = true;
            this.cbox_patient_doc_name.Location = new System.Drawing.Point(400, 231);
            this.cbox_patient_doc_name.Name = "cbox_patient_doc_name";
            this.cbox_patient_doc_name.Size = new System.Drawing.Size(393, 35);
            this.cbox_patient_doc_name.TabIndex = 4;
            // 
            // cbox_patient_doc_time
            // 
            this.cbox_patient_doc_time.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cbox_patient_doc_time.FormattingEnabled = true;
            this.cbox_patient_doc_time.Location = new System.Drawing.Point(400, 291);
            this.cbox_patient_doc_time.Name = "cbox_patient_doc_time";
            this.cbox_patient_doc_time.Size = new System.Drawing.Size(393, 35);
            this.cbox_patient_doc_time.TabIndex = 5;
            // 
            // btn_patient_ap_submit
            // 
            this.btn_patient_ap_submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_patient_ap_submit.FlatAppearance.BorderSize = 2;
            this.btn_patient_ap_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_patient_ap_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_ap_submit.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_patient_ap_submit.ForeColor = System.Drawing.Color.White;
            this.btn_patient_ap_submit.Location = new System.Drawing.Point(654, 359);
            this.btn_patient_ap_submit.Name = "btn_patient_ap_submit";
            this.btn_patient_ap_submit.Size = new System.Drawing.Size(139, 46);
            this.btn_patient_ap_submit.TabIndex = 6;
            this.btn_patient_ap_submit.Text = "Submit";
            this.btn_patient_ap_submit.UseVisualStyleBackColor = true;
            // 
            // patient_appointment_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btn_patient_ap_submit);
            this.Controls.Add(this.cbox_patient_doc_time);
            this.Controls.Add(this.cbox_patient_doc_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "patient_appointment_panel";
            this.Size = new System.Drawing.Size(1010, 763);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_patient_doc_name;
        private System.Windows.Forms.ComboBox cbox_patient_doc_time;
        private System.Windows.Forms.Button btn_patient_ap_submit;
    }
}
