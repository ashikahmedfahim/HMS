namespace hp2
{
    partial class patient_service_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_service_panel));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_info_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_service_submit = new System.Windows.Forms.Button();
            this.btn_info_2 = new System.Windows.Forms.Button();
            this.lbl_charge = new System.Windows.Forms.Label();
            this.comboBox_service = new System.Windows.Forms.ComboBox();
            this.btn_show_charge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Service you wants to Delete :";
            // 
            // btn_info_1
            // 
            this.btn_info_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_info_1.FlatAppearance.BorderSize = 0;
            this.btn_info_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info_1.Image = ((System.Drawing.Image)(resources.GetObject("btn_info_1.Image")));
            this.btn_info_1.Location = new System.Drawing.Point(776, 281);
            this.btn_info_1.Name = "btn_info_1";
            this.btn_info_1.Size = new System.Drawing.Size(33, 30);
            this.btn_info_1.TabIndex = 1;
            this.btn_info_1.UseVisualStyleBackColor = true;
            this.btn_info_1.Click += new System.EventHandler(this.btn_info_1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Charge :";
            // 
            // btn_service_submit
            // 
            this.btn_service_submit.FlatAppearance.BorderSize = 2;
            this.btn_service_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_service_submit.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btn_service_submit.ForeColor = System.Drawing.Color.White;
            this.btn_service_submit.Location = new System.Drawing.Point(653, 394);
            this.btn_service_submit.Name = "btn_service_submit";
            this.btn_service_submit.Size = new System.Drawing.Size(117, 42);
            this.btn_service_submit.TabIndex = 5;
            this.btn_service_submit.Text = "DELETE";
            this.btn_service_submit.UseVisualStyleBackColor = true;
            this.btn_service_submit.Click += new System.EventHandler(this.btn_service_submit_Click);
            // 
            // btn_info_2
            // 
            this.btn_info_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_info_2.FlatAppearance.BorderSize = 0;
            this.btn_info_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info_2.Image = ((System.Drawing.Image)(resources.GetObject("btn_info_2.Image")));
            this.btn_info_2.Location = new System.Drawing.Point(776, 334);
            this.btn_info_2.Name = "btn_info_2";
            this.btn_info_2.Size = new System.Drawing.Size(33, 26);
            this.btn_info_2.TabIndex = 6;
            this.btn_info_2.UseVisualStyleBackColor = true;
            this.btn_info_2.Click += new System.EventHandler(this.btn_info_2_Click);
            // 
            // lbl_charge
            // 
            this.lbl_charge.AutoSize = true;
            this.lbl_charge.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_charge.ForeColor = System.Drawing.Color.White;
            this.lbl_charge.Location = new System.Drawing.Point(448, 337);
            this.lbl_charge.Name = "lbl_charge";
            this.lbl_charge.Size = new System.Drawing.Size(74, 23);
            this.lbl_charge.TabIndex = 8;
            this.lbl_charge.Text = "invalid";
            // 
            // comboBox_service
            // 
            this.comboBox_service.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_service.FormattingEnabled = true;
            this.comboBox_service.Location = new System.Drawing.Point(452, 283);
            this.comboBox_service.Name = "comboBox_service";
            this.comboBox_service.Size = new System.Drawing.Size(318, 31);
            this.comboBox_service.TabIndex = 12;
            // 
            // btn_show_charge
            // 
            this.btn_show_charge.FlatAppearance.BorderSize = 0;
            this.btn_show_charge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_charge.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_charge.ForeColor = System.Drawing.Color.Red;
            this.btn_show_charge.Location = new System.Drawing.Point(577, 324);
            this.btn_show_charge.Name = "btn_show_charge";
            this.btn_show_charge.Size = new System.Drawing.Size(193, 43);
            this.btn_show_charge.TabIndex = 13;
            this.btn_show_charge.Text = "Show Charge";
            this.btn_show_charge.UseVisualStyleBackColor = true;
            this.btn_show_charge.Click += new System.EventHandler(this.btn_show_charge_Click);
            // 
            // patient_service_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btn_show_charge);
            this.Controls.Add(this.comboBox_service);
            this.Controls.Add(this.lbl_charge);
            this.Controls.Add(this.btn_info_2);
            this.Controls.Add(this.btn_service_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_info_1);
            this.Controls.Add(this.label1);
            this.Name = "patient_service_panel";
            this.Size = new System.Drawing.Size(1010, 763);
            this.Load += new System.EventHandler(this.patient_service_panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_info_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_service_submit;
        private System.Windows.Forms.Button btn_info_2;
        private System.Windows.Forms.Label lbl_charge;
        private System.Windows.Forms.ComboBox comboBox_service;
        private System.Windows.Forms.Button btn_show_charge;
    }
}
