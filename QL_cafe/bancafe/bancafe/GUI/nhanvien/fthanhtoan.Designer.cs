namespace bancafe
{
    partial class fthanhtoan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewHDThanhtoan = new System.Windows.Forms.DataGridView();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxHoaDon = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonThanhtoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDThanhtoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxHoaDon.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHDThanhtoan
            // 
            this.dataGridViewHDThanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHDThanhtoan.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewHDThanhtoan.Name = "dataGridViewHDThanhtoan";
            this.dataGridViewHDThanhtoan.Size = new System.Drawing.Size(544, 276);
            this.dataGridViewHDThanhtoan.TabIndex = 0;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.Location = new System.Drawing.Point(6, 19);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(420, 62);
            this.txtTongtien.TabIndex = 2;
            this.txtTongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng tiền(VNĐ)";
            // 
            // groupBoxHoaDon
            // 
            this.groupBoxHoaDon.Controls.Add(this.dataGridViewHDThanhtoan);
            this.groupBoxHoaDon.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHoaDon.Name = "groupBoxHoaDon";
            this.groupBoxHoaDon.Size = new System.Drawing.Size(556, 301);
            this.groupBoxHoaDon.TabIndex = 4;
            this.groupBoxHoaDon.TabStop = false;
            this.groupBoxHoaDon.Text = "Hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonThanhtoan);
            this.groupBox3.Location = new System.Drawing.Point(450, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 93);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // buttonThanhtoan
            // 
            this.buttonThanhtoan.BackColor = System.Drawing.Color.LightGreen;
            this.buttonThanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThanhtoan.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhtoan.ForeColor = System.Drawing.Color.White;
            this.buttonThanhtoan.Image = global::bancafe.Properties.Resources.thanhtoan2;
            this.buttonThanhtoan.Location = new System.Drawing.Point(6, 17);
            this.buttonThanhtoan.Name = "buttonThanhtoan";
            this.buttonThanhtoan.Size = new System.Drawing.Size(106, 70);
            this.buttonThanhtoan.TabIndex = 1;
            this.buttonThanhtoan.Text = "Xác nhận";
            this.buttonThanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonThanhtoan.UseVisualStyleBackColor = false;
            this.buttonThanhtoan.Click += new System.EventHandler(this.buttonThanhtoan_Click);
            // 
            // fthanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(581, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fthanhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDThanhtoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxHoaDon.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHDThanhtoan;
        private System.Windows.Forms.Button buttonThanhtoan;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}