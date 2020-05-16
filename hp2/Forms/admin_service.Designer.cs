namespace hp2
{
    partial class admin_service
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
            this.btn_ser_clear = new System.Windows.Forms.Button();
            this.btn_ser_delete = new System.Windows.Forms.Button();
            this.btn_ser_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dGv_admin_doctor = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_room_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_admin_doctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ser_clear
            // 
            this.btn_ser_clear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ser_clear.Location = new System.Drawing.Point(497, 161);
            this.btn_ser_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ser_clear.Name = "btn_ser_clear";
            this.btn_ser_clear.Size = new System.Drawing.Size(74, 32);
            this.btn_ser_clear.TabIndex = 22;
            this.btn_ser_clear.Text = "Clear";
            this.btn_ser_clear.UseVisualStyleBackColor = true;
            // 
            // btn_ser_delete
            // 
            this.btn_ser_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ser_delete.Location = new System.Drawing.Point(497, 107);
            this.btn_ser_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ser_delete.Name = "btn_ser_delete";
            this.btn_ser_delete.Size = new System.Drawing.Size(74, 32);
            this.btn_ser_delete.TabIndex = 21;
            this.btn_ser_delete.Text = "Delete";
            this.btn_ser_delete.UseVisualStyleBackColor = true;
            // 
            // btn_ser_add
            // 
            this.btn_ser_add.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ser_add.Location = new System.Drawing.Point(497, 54);
            this.btn_ser_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ser_add.Name = "btn_ser_add";
            this.btn_ser_add.Size = new System.Drawing.Size(74, 32);
            this.btn_ser_add.TabIndex = 19;
            this.btn_ser_add.Text = "Add";
            this.btn_ser_add.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cost :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(162, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(223, 156);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 27);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(223, 105);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 27);
            this.textBox2.TabIndex = 12;
            // 
            // dGv_admin_doctor
            // 
            this.dGv_admin_doctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_admin_doctor.Location = new System.Drawing.Point(20, 318);
            this.dGv_admin_doctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGv_admin_doctor.Name = "dGv_admin_doctor";
            this.dGv_admin_doctor.RowHeadersWidth = 51;
            this.dGv_admin_doctor.RowTemplate.Height = 24;
            this.dGv_admin_doctor.Size = new System.Drawing.Size(717, 286);
            this.dGv_admin_doctor.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(223, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 27);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Service No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(88, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Update Cost :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "New Cost :";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(222, 263);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 27);
            this.textBox4.TabIndex = 38;
            // 
            // btn_room_update
            // 
            this.btn_room_update.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room_update.Location = new System.Drawing.Point(497, 263);
            this.btn_room_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_room_update.Name = "btn_room_update";
            this.btn_room_update.Size = new System.Drawing.Size(74, 32);
            this.btn_room_update.TabIndex = 37;
            this.btn_room_update.Text = "Update";
            this.btn_room_update.UseVisualStyleBackColor = true;
            // 
            // admin_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_room_update);
            this.Controls.Add(this.btn_ser_clear);
            this.Controls.Add(this.btn_ser_delete);
            this.Controls.Add(this.btn_ser_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dGv_admin_doctor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admin_service";
            this.Size = new System.Drawing.Size(758, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_admin_doctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ser_clear;
        private System.Windows.Forms.Button btn_ser_delete;
        private System.Windows.Forms.Button btn_ser_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dGv_admin_doctor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_room_update;
    }
}
