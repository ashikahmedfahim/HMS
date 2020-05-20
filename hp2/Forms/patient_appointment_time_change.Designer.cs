namespace hp2.Forms
{
    partial class patient_appointment_time_change
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
            this.btn_patient_ap_time_change_submit = new System.Windows.Forms.Button();
            this.cbox_patient_doc_time = new System.Windows.Forms.ComboBox();
            this.lbl_p_app_t_c = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_patient_ap_time_change_submit
            // 
            this.btn_patient_ap_time_change_submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_patient_ap_time_change_submit.FlatAppearance.BorderSize = 2;
            this.btn_patient_ap_time_change_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_patient_ap_time_change_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_ap_time_change_submit.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_patient_ap_time_change_submit.ForeColor = System.Drawing.Color.White;
            this.btn_patient_ap_time_change_submit.Location = new System.Drawing.Point(712, 321);
            this.btn_patient_ap_time_change_submit.Name = "btn_patient_ap_time_change_submit";
            this.btn_patient_ap_time_change_submit.Size = new System.Drawing.Size(139, 46);
            this.btn_patient_ap_time_change_submit.TabIndex = 11;
            this.btn_patient_ap_time_change_submit.Text = "Submit";
            this.btn_patient_ap_time_change_submit.UseVisualStyleBackColor = true;
            // 
            // cbox_patient_doc_time
            // 
            this.cbox_patient_doc_time.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cbox_patient_doc_time.FormattingEnabled = true;
            this.cbox_patient_doc_time.Location = new System.Drawing.Point(458, 268);
            this.cbox_patient_doc_time.Name = "cbox_patient_doc_time";
            this.cbox_patient_doc_time.Size = new System.Drawing.Size(393, 35);
            this.cbox_patient_doc_time.TabIndex = 10;
            // 
            // lbl_p_app_t_c
            // 
            this.lbl_p_app_t_c.AutoSize = true;
            this.lbl_p_app_t_c.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbl_p_app_t_c.ForeColor = System.Drawing.Color.White;
            this.lbl_p_app_t_c.Location = new System.Drawing.Point(98, 268);
            this.lbl_p_app_t_c.Name = "lbl_p_app_t_c";
            this.lbl_p_app_t_c.Size = new System.Drawing.Size(354, 30);
            this.lbl_p_app_t_c.TabIndex = 12;
            this.lbl_p_app_t_c.Text = "Select New Available Time : ";
            // 
            // patient_appointment_time_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.lbl_p_app_t_c);
            this.Controls.Add(this.btn_patient_ap_time_change_submit);
            this.Controls.Add(this.cbox_patient_doc_time);
            this.Name = "patient_appointment_time_change";
            this.Size = new System.Drawing.Size(1010, 763);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_patient_ap_time_change_submit;
        private System.Windows.Forms.ComboBox cbox_patient_doc_time;
        private System.Windows.Forms.Label lbl_p_app_t_c;
    }
}
