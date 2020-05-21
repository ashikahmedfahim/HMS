namespace hp2
{
    partial class patient_password_change
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
            this.txtbox_pass_change = new System.Windows.Forms.TextBox();
            this.btn_patient_pass_change = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter new Password :";
            // 
            // txtbox_pass_change
            // 
            this.txtbox_pass_change.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.txtbox_pass_change.Location = new System.Drawing.Point(378, 296);
            this.txtbox_pass_change.Name = "txtbox_pass_change";
            this.txtbox_pass_change.Size = new System.Drawing.Size(409, 36);
            this.txtbox_pass_change.TabIndex = 2;
            // 
            // btn_patient_pass_change
            // 
            this.btn_patient_pass_change.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_patient_pass_change.FlatAppearance.BorderSize = 2;
            this.btn_patient_pass_change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_patient_pass_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient_pass_change.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_patient_pass_change.ForeColor = System.Drawing.Color.White;
            this.btn_patient_pass_change.Location = new System.Drawing.Point(648, 355);
            this.btn_patient_pass_change.Name = "btn_patient_pass_change";
            this.btn_patient_pass_change.Size = new System.Drawing.Size(139, 46);
            this.btn_patient_pass_change.TabIndex = 18;
            this.btn_patient_pass_change.Text = "Confirm";
            this.btn_patient_pass_change.UseVisualStyleBackColor = true;
            this.btn_patient_pass_change.Click += new System.EventHandler(this.btn_patient_pass_change_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(705, 666);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 32);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // patient_password_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_patient_pass_change);
            this.Controls.Add(this.txtbox_pass_change);
            this.Controls.Add(this.label1);
            this.Name = "patient_password_change";
            this.Size = new System.Drawing.Size(1010, 763);
            this.Load += new System.EventHandler(this.patient_password_change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_pass_change;
        private System.Windows.Forms.Button btn_patient_pass_change;
        private System.Windows.Forms.Button btn_back;
    }
}
