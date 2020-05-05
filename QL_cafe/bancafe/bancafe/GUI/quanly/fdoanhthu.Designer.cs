namespace bancafe
{
    partial class fdoanhthu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rgDSHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTinhtoan = new System.Windows.Forms.DateTimePicker();
            this.btnChitiethoadon = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTinhtoan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgDSHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChitiethoadon);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rgDSHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 467);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // rgDSHoaDon
            // 
            this.rgDSHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rgDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rgDSHoaDon.Location = new System.Drawing.Point(6, 19);
            this.rgDSHoaDon.Name = "rgDSHoaDon";
            this.rgDSHoaDon.Size = new System.Drawing.Size(732, 442);
            this.rgDSHoaDon.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Location = new System.Drawing.Point(12, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 186);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lịch";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(25, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRefresh);
            this.groupBox5.Controls.Add(this.btnTimkiem);
            this.groupBox5.Controls.Add(this.txtTimkiem);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(12, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm hóa đơn";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(102, 27);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(142, 20);
            this.txtTimkiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimePickerTinhtoan);
            this.groupBox6.Controls.Add(this.btnTinhtoan);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(258, 93);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tính toán doanh thu";
            // 
            // dateTimePickerTinhtoan
            // 
            this.dateTimePickerTinhtoan.Location = new System.Drawing.Point(17, 19);
            this.dateTimePickerTinhtoan.Name = "dateTimePickerTinhtoan";
            this.dateTimePickerTinhtoan.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerTinhtoan.TabIndex = 1;
            // 
            // btnChitiethoadon
            // 
            this.btnChitiethoadon.BackColor = System.Drawing.Color.IndianRed;
            this.btnChitiethoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChitiethoadon.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitiethoadon.ForeColor = System.Drawing.Color.White;
            this.btnChitiethoadon.Image = global::bancafe.Properties.Resources.edit2;
            this.btnChitiethoadon.Location = new System.Drawing.Point(6, 13);
            this.btnChitiethoadon.Name = "btnChitiethoadon";
            this.btnChitiethoadon.Size = new System.Drawing.Size(246, 51);
            this.btnChitiethoadon.TabIndex = 5;
            this.btnChitiethoadon.Text = "Chi tiết hóa đơn";
            this.btnChitiethoadon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChitiethoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChitiethoadon.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightGreen;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::bancafe.Properties.Resources.reload1;
            this.btnRefresh.Location = new System.Drawing.Point(134, 53);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 41);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.LightPink;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Image = global::bancafe.Properties.Resources.loupe1;
            this.btnTimkiem.Location = new System.Drawing.Point(17, 52);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(110, 41);
            this.btnTimkiem.TabIndex = 6;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // btnTinhtoan
            // 
            this.btnTinhtoan.BackColor = System.Drawing.Color.LightBlue;
            this.btnTinhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhtoan.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhtoan.ForeColor = System.Drawing.Color.White;
            this.btnTinhtoan.Image = global::bancafe.Properties.Resources.exit__1_2;
            this.btnTinhtoan.Location = new System.Drawing.Point(163, 19);
            this.btnTinhtoan.Name = "btnTinhtoan";
            this.btnTinhtoan.Size = new System.Drawing.Size(89, 68);
            this.btnTinhtoan.TabIndex = 7;
            this.btnTinhtoan.Text = "Tính toán";
            this.btnTinhtoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTinhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTinhtoan.UseVisualStyleBackColor = false;
            // 
            // fdoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Name = "fdoanhthu";
            this.Size = new System.Drawing.Size(1032, 491);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgDSHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView rgDSHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTinhtoan;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnChitiethoadon;
        private System.Windows.Forms.Button btnTinhtoan;
        private System.Windows.Forms.Button btnRefresh;
    }
}
