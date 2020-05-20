namespace hp2
{
    partial class patient_report_panel
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
            this.lbl_rno = new System.Windows.Forms.Label();
            this.lbl_rname = new System.Windows.Forms.Label();
            this.lbl_dname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(237, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor Name :";
            // 
            // lbl_rno
            // 
            this.lbl_rno.AutoSize = true;
            this.lbl_rno.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbl_rno.ForeColor = System.Drawing.Color.White;
            this.lbl_rno.Location = new System.Drawing.Point(445, 270);
            this.lbl_rno.Name = "lbl_rno";
            this.lbl_rno.Size = new System.Drawing.Size(93, 30);
            this.lbl_rno.TabIndex = 3;
            this.lbl_rno.Text = "invalid";
            // 
            // lbl_rname
            // 
            this.lbl_rname.AutoSize = true;
            this.lbl_rname.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbl_rname.ForeColor = System.Drawing.Color.White;
            this.lbl_rname.Location = new System.Drawing.Point(445, 319);
            this.lbl_rname.Name = "lbl_rname";
            this.lbl_rname.Size = new System.Drawing.Size(93, 30);
            this.lbl_rname.TabIndex = 4;
            this.lbl_rname.Text = "invalid";
            // 
            // lbl_dname
            // 
            this.lbl_dname.AutoSize = true;
            this.lbl_dname.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lbl_dname.ForeColor = System.Drawing.Color.White;
            this.lbl_dname.Location = new System.Drawing.Point(445, 368);
            this.lbl_dname.Name = "lbl_dname";
            this.lbl_dname.Size = new System.Drawing.Size(93, 30);
            this.lbl_dname.TabIndex = 5;
            this.lbl_dname.Text = "invalid";
            // 
            // patient_report_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.lbl_dname);
            this.Controls.Add(this.lbl_rname);
            this.Controls.Add(this.lbl_rno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "patient_report_panel";
            this.Size = new System.Drawing.Size(1010, 763);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_rno;
        private System.Windows.Forms.Label lbl_rname;
        private System.Windows.Forms.Label lbl_dname;
    }
}
