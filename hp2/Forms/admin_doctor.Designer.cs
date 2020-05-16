namespace hp2
{
    partial class admin_doctor
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
            this.btn_edit_doctor_info = new System.Windows.Forms.Button();
            this.btn_add_new_doctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_patient_search = new System.Windows.Forms.Button();
            this.txtb_patient_search = new System.Windows.Forms.TextBox();
            this.dGv_admin_patient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_admin_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit_doctor_info
            // 
            this.btn_edit_doctor_info.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_doctor_info.Location = new System.Drawing.Point(20, 510);
            this.btn_edit_doctor_info.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit_doctor_info.Name = "btn_edit_doctor_info";
            this.btn_edit_doctor_info.Size = new System.Drawing.Size(134, 32);
            this.btn_edit_doctor_info.TabIndex = 8;
            this.btn_edit_doctor_info.Text = "Edit Doctor Info";
            this.btn_edit_doctor_info.UseVisualStyleBackColor = true;
            this.btn_edit_doctor_info.Click += new System.EventHandler(this.btn_edit_doctor_info_Click);
            // 
            // btn_add_new_doctor
            // 
            this.btn_add_new_doctor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_doctor.Location = new System.Drawing.Point(20, 560);
            this.btn_add_new_doctor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_new_doctor.Name = "btn_add_new_doctor";
            this.btn_add_new_doctor.Size = new System.Drawing.Size(134, 32);
            this.btn_add_new_doctor.TabIndex = 9;
            this.btn_add_new_doctor.Text = "Add New Doctor";
            this.btn_add_new_doctor.UseVisualStyleBackColor = true;
            this.btn_add_new_doctor.Click += new System.EventHandler(this.btn_add_new_doctor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Doctor ID :";
            // 
            // btn_patient_search
            // 
            this.btn_patient_search.FlatAppearance.BorderSize = 0;
            this.btn_patient_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient_search.ForeColor = System.Drawing.Color.White;
            this.btn_patient_search.Location = new System.Drawing.Point(567, 102);
            this.btn_patient_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_patient_search.Name = "btn_patient_search";
            this.btn_patient_search.Size = new System.Drawing.Size(74, 26);
            this.btn_patient_search.TabIndex = 23;
            this.btn_patient_search.Text = "Search";
            this.btn_patient_search.UseVisualStyleBackColor = true;
            // 
            // txtb_patient_search
            // 
            this.txtb_patient_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_patient_search.Location = new System.Drawing.Point(221, 102);
            this.txtb_patient_search.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_patient_search.Name = "txtb_patient_search";
            this.txtb_patient_search.Size = new System.Drawing.Size(343, 27);
            this.txtb_patient_search.TabIndex = 22;
            // 
            // dGv_admin_patient
            // 
            this.dGv_admin_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_admin_patient.Location = new System.Drawing.Point(20, 180);
            this.dGv_admin_patient.Margin = new System.Windows.Forms.Padding(2);
            this.dGv_admin_patient.Name = "dGv_admin_patient";
            this.dGv_admin_patient.RowHeadersWidth = 51;
            this.dGv_admin_patient.RowTemplate.Height = 24;
            this.dGv_admin_patient.Size = new System.Drawing.Size(717, 286);
            this.dGv_admin_patient.TabIndex = 21;
            // 
            // admin_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_patient_search);
            this.Controls.Add(this.txtb_patient_search);
            this.Controls.Add(this.dGv_admin_patient);
            this.Controls.Add(this.btn_add_new_doctor);
            this.Controls.Add(this.btn_edit_doctor_info);
            this.Name = "admin_doctor";
            this.Size = new System.Drawing.Size(758, 650);
            this.Load += new System.EventHandler(this.admin_doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_admin_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_edit_doctor_info;
        private System.Windows.Forms.Button btn_add_new_doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_patient_search;
        private System.Windows.Forms.TextBox txtb_patient_search;
        private System.Windows.Forms.DataGridView dGv_admin_patient;
    }
}
