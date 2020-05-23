namespace hp2
{
    partial class patient_bill_panel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_service_charge = new System.Windows.Forms.Label();
            this.lbl_room_charge = new System.Windows.Forms.Label();
            this.lbl_total_charge = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doctor Charge :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(300, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Charge :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(314, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Charge :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Service Charge :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(501, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "500";
            // 
            // lbl_service_charge
            // 
            this.lbl_service_charge.AutoSize = true;
            this.lbl_service_charge.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbl_service_charge.ForeColor = System.Drawing.Color.White;
            this.lbl_service_charge.Location = new System.Drawing.Point(501, 266);
            this.lbl_service_charge.Name = "lbl_service_charge";
            this.lbl_service_charge.Size = new System.Drawing.Size(93, 30);
            this.lbl_service_charge.TabIndex = 4;
            this.lbl_service_charge.Text = "invalid";
            // 
            // lbl_room_charge
            // 
            this.lbl_room_charge.AutoSize = true;
            this.lbl_room_charge.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbl_room_charge.ForeColor = System.Drawing.Color.White;
            this.lbl_room_charge.Location = new System.Drawing.Point(501, 323);
            this.lbl_room_charge.Name = "lbl_room_charge";
            this.lbl_room_charge.Size = new System.Drawing.Size(93, 30);
            this.lbl_room_charge.TabIndex = 4;
            this.lbl_room_charge.Text = "invalid";
            // 
            // lbl_total_charge
            // 
            this.lbl_total_charge.AutoSize = true;
            this.lbl_total_charge.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbl_total_charge.ForeColor = System.Drawing.Color.White;
            this.lbl_total_charge.Location = new System.Drawing.Point(501, 380);
            this.lbl_total_charge.Name = "lbl_total_charge";
            this.lbl_total_charge.Size = new System.Drawing.Size(93, 30);
            this.lbl_total_charge.TabIndex = 4;
            this.lbl_total_charge.Text = "invalid";
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(411, 452);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(125, 43);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // patient_bill_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_total_charge);
            this.Controls.Add(this.lbl_room_charge);
            this.Controls.Add(this.lbl_service_charge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "patient_bill_panel";
            this.Size = new System.Drawing.Size(1010, 763);
            this.Load += new System.EventHandler(this.patient_bill_panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_service_charge;
        private System.Windows.Forms.Label lbl_room_charge;
        private System.Windows.Forms.Label lbl_total_charge;
        private System.Windows.Forms.Button btn_refresh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
