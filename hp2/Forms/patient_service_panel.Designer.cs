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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_info_2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Service :";
            // 
            // btn_info_1
            // 
            this.btn_info_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_info_1.FlatAppearance.BorderSize = 0;
            this.btn_info_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info_1.Image = ((System.Drawing.Image)(resources.GetObject("btn_info_1.Image")));
            this.btn_info_1.Location = new System.Drawing.Point(797, 271);
            this.btn_info_1.Name = "btn_info_1";
            this.btn_info_1.Size = new System.Drawing.Size(33, 30);
            this.btn_info_1.TabIndex = 1;
            this.btn_info_1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Payment Method :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(674, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_info_2
            // 
            this.btn_info_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_info_2.FlatAppearance.BorderSize = 0;
            this.btn_info_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info_2.Image = ((System.Drawing.Image)(resources.GetObject("btn_info_2.Image")));
            this.btn_info_2.Location = new System.Drawing.Point(797, 329);
            this.btn_info_2.Name = "btn_info_2";
            this.btn_info_2.Size = new System.Drawing.Size(33, 30);
            this.btn_info_2.TabIndex = 6;
            this.btn_info_2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AllowDrop = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "X-Ray",
            "ECG",
            "Eco",
            "Surgery"});
            this.checkedListBox1.Location = new System.Drawing.Point(452, 271);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(339, 31);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.UseCompatibleTextRendering = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.AllowDrop = true;
            this.checkedListBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Mobile Banking"});
            this.checkedListBox2.Location = new System.Drawing.Point(452, 329);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(339, 31);
            this.checkedListBox2.TabIndex = 8;
            // 
            // patient_service_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btn_info_2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_info_1);
            this.Controls.Add(this.label1);
            this.Name = "patient_service_panel";
            this.Size = new System.Drawing.Size(1010, 763);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_info_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_info_2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}
