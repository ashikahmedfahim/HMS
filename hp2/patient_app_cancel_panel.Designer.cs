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
            this.btn_patient_ap_cancel = new System.Windows.Forms.Button();
            this.lbl_p_app_t_c = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_patient_ap_cancel
            // 
            this.btn_patient_ap_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_patient_ap_cancel.FlatAppearance.BorderSize = 2;
            this.btn_patient_ap_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_patient_ap_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_ap_cancel.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_patient_ap_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_patient_ap_cancel.Location = new System.Drawing.Point(422, 402);
            this.btn_patient_ap_cancel.Name = "btn_patient_ap_cancel";
            this.btn_patient_ap_cancel.Size = new System.Drawing.Size(139, 46);
            this.btn_patient_ap_cancel.TabIndex = 22;
            this.btn_patient_ap_cancel.Text = "Yes";
            this.btn_patient_ap_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_p_app_t_c
            // 
            this.lbl_p_app_t_c.AutoSize = true;
            this.lbl_p_app_t_c.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbl_p_app_t_c.ForeColor = System.Drawing.Color.White;
            this.lbl_p_app_t_c.Location = new System.Drawing.Point(322, 352);
            this.lbl_p_app_t_c.Name = "lbl_p_app_t_c";
            this.lbl_p_app_t_c.Size = new System.Drawing.Size(366, 30);
            this.lbl_p_app_t_c.TabIndex = 21;
            this.lbl_p_app_t_c.Text = "Want to Cancel Appiontment";
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(795, 710);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 32);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // patient_app_cancel_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_patient_ap_cancel);
            this.Controls.Add(this.lbl_p_app_t_c);
            this.Name = "patient_app_cancel_panel";
            this.Size = new System.Drawing.Size(1011, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_patient_ap_cancel;
        private System.Windows.Forms.Label lbl_p_app_t_c;
        private System.Windows.Forms.Button btn_back;
    }
}
