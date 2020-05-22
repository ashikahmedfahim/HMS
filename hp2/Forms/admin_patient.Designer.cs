namespace hp2
{
    partial class admin_patient
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.UserIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCancelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDColumn,
            this.NameColumn,
            this.PhoneColumn,
            this.AddressColumn});
            this.dataGridView.Location = new System.Drawing.Point(64, 55);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(584, 191);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // UserIDColumn
            // 
            this.UserIDColumn.DataPropertyName = "USER_ID";
            this.UserIDColumn.HeaderText = "Patient ID";
            this.UserIDColumn.Name = "UserIDColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "NAME";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 130;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.DataPropertyName = "PHONE";
            this.PhoneColumn.HeaderText = "Phone";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.Width = 140;
            // 
            // AddressColumn
            // 
            this.AddressColumn.DataPropertyName = "ADDRESS";
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.Width = 160;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(511, 290);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 32);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(74, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Doctor Name:";
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(207, 290);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(249, 28);
            this.cmbDoctorName.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeColumn,
            this.DateColumn,
            this.IsCancelColumn,
            this.PaymentColumn});
            this.dataGridView1.Location = new System.Drawing.Point(64, 368);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 214);
            this.dataGridView1.TabIndex = 60;
            // 
            // TimeColumn
            // 
            this.TimeColumn.DataPropertyName = "TIME";
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.Width = 130;
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "DATE";
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 140;
            // 
            // IsCancelColumn
            // 
            this.IsCancelColumn.DataPropertyName = "IS_CANCEL";
            this.IsCancelColumn.HeaderText = "Cancel";
            this.IsCancelColumn.Name = "IsCancelColumn";
            this.IsCancelColumn.Width = 130;
            // 
            // PaymentColumn
            // 
            this.PaymentColumn.DataPropertyName = "IS_PAID";
            this.PaymentColumn.HeaderText = "Payment";
            this.PaymentColumn.Name = "PaymentColumn";
            this.PaymentColumn.Width = 130;
            // 
            // admin_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDoctorName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "admin_patient";
            this.Size = new System.Drawing.Size(758, 650);
            this.Load += new System.EventHandler(this.admin_patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCancelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentColumn;
    }
}
