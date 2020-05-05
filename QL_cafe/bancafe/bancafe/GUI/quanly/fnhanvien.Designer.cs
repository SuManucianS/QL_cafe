namespace bancafe
{
    partial class fnhanvien
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
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lv_listnv = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePickernNgaysinh = new System.Windows.Forms.DateTimePicker();
			this.rdbtnNu = new System.Windows.Forms.RadioButton();
			this.rdbtnNam = new System.Windows.Forms.RadioButton();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtTimkiem = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.IDNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NgayVaoLam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TenBoPhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bTrangthai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_craccount = new System.Windows.Forms.Button();
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.groupBox5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lv_listnv);
			this.groupBox5.Location = new System.Drawing.Point(394, 13);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(626, 464);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Danh sách nhân viên";
			// 
			// lv_listnv
			// 
			this.lv_listnv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDNhanVien,
            this.TenNhanVien,
            this.GioiTinh,
            this.NgaySinh,
            this.SoDienThoai,
            this.NgayVaoLam,
            this.TenBoPhan,
            this.bTrangthai});
			this.lv_listnv.HideSelection = false;
			this.lv_listnv.Location = new System.Drawing.Point(15, 19);
			this.lv_listnv.Name = "lv_listnv";
			this.lv_listnv.Size = new System.Drawing.Size(620, 439);
			this.lv_listnv.TabIndex = 0;
			this.lv_listnv.UseCompatibleStateImageBehavior = false;
			this.lv_listnv.View = System.Windows.Forms.View.Details;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateTimePickernNgaysinh);
			this.groupBox1.Controls.Add(this.rdbtnNu);
			this.groupBox1.Controls.Add(this.rdbtnNam);
			this.groupBox1.Controls.Add(this.txtSdt);
			this.groupBox1.Controls.Add(this.txtTenNV);
			this.groupBox1.Controls.Add(this.txtMaNV);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(375, 204);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin nhân viên";
			// 
			// dateTimePickernNgaysinh
			// 
			this.dateTimePickernNgaysinh.Location = new System.Drawing.Point(105, 96);
			this.dateTimePickernNgaysinh.Name = "dateTimePickernNgaysinh";
			this.dateTimePickernNgaysinh.Size = new System.Drawing.Size(229, 20);
			this.dateTimePickernNgaysinh.TabIndex = 10;
			// 
			// rdbtnNu
			// 
			this.rdbtnNu.AutoSize = true;
			this.rdbtnNu.Location = new System.Drawing.Point(162, 135);
			this.rdbtnNu.Name = "rdbtnNu";
			this.rdbtnNu.Size = new System.Drawing.Size(39, 17);
			this.rdbtnNu.TabIndex = 9;
			this.rdbtnNu.TabStop = true;
			this.rdbtnNu.Text = "Nữ";
			this.rdbtnNu.UseVisualStyleBackColor = true;
			// 
			// rdbtnNam
			// 
			this.rdbtnNam.AutoSize = true;
			this.rdbtnNam.Location = new System.Drawing.Point(105, 135);
			this.rdbtnNam.Name = "rdbtnNam";
			this.rdbtnNam.Size = new System.Drawing.Size(47, 17);
			this.rdbtnNam.TabIndex = 8;
			this.rdbtnNam.TabStop = true;
			this.rdbtnNam.Text = "Nam";
			this.rdbtnNam.UseVisualStyleBackColor = true;
			// 
			// txtSdt
			// 
			this.txtSdt.Location = new System.Drawing.Point(105, 167);
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Size = new System.Drawing.Size(229, 20);
			this.txtSdt.TabIndex = 7;
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(105, 60);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(229, 20);
			this.txtTenNV.TabIndex = 6;
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(105, 28);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(229, 20);
			this.txtMaNV.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Số điện thoại:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giới tính";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày sinh:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên nhân viên:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhân viên:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnTimkiem);
			this.groupBox3.Controls.Add(this.txtTimkiem);
			this.groupBox3.Location = new System.Drawing.Point(255, 223);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(133, 144);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tìm nhân viên";
			// 
			// txtTimkiem
			// 
			this.txtTimkiem.Location = new System.Drawing.Point(6, 19);
			this.txtTimkiem.Name = "txtTimkiem";
			this.txtTimkiem.Size = new System.Drawing.Size(121, 20);
			this.txtTimkiem.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnLuu);
			this.groupBox4.Controls.Add(this.btnXoa);
			this.groupBox4.Controls.Add(this.btnSua);
			this.groupBox4.Controls.Add(this.btnThem);
			this.groupBox4.Location = new System.Drawing.Point(13, 373);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(375, 104);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Chức năng";
			// 
			// IDNhanVien
			// 
			this.IDNhanVien.Text = "ID";
			// 
			// TenNhanVien
			// 
			this.TenNhanVien.Text = "Họ tên";
			this.TenNhanVien.Width = 97;
			// 
			// GioiTinh
			// 
			this.GioiTinh.Text = "Giới tính";
			this.GioiTinh.Width = 63;
			// 
			// NgaySinh
			// 
			this.NgaySinh.Text = "Ngày Sinh";
			this.NgaySinh.Width = 73;
			// 
			// SoDienThoai
			// 
			this.SoDienThoai.Text = "SDT";
			this.SoDienThoai.Width = 84;
			// 
			// NgayVaoLam
			// 
			this.NgayVaoLam.Text = "Ngày vào làm";
			this.NgayVaoLam.Width = 91;
			// 
			// TenBoPhan
			// 
			this.TenBoPhan.Text = "Bộ phận";
			this.TenBoPhan.Width = 79;
			// 
			// bTrangthai
			// 
			this.bTrangthai.Text = "Trạng thái ";
			this.bTrangthai.Width = 89;
			// 
			// btn_craccount
			// 
			this.btn_craccount.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btn_craccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_craccount.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_craccount.ForeColor = System.Drawing.Color.White;
			this.btn_craccount.Image = global::bancafe.Properties.Resources.edit;
			this.btn_craccount.Location = new System.Drawing.Point(38, 268);
			this.btn_craccount.Name = "btn_craccount";
			this.btn_craccount.Size = new System.Drawing.Size(163, 66);
			this.btn_craccount.TabIndex = 3;
			this.btn_craccount.Text = "Tạo tài khoản";
			this.btn_craccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_craccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_craccount.UseVisualStyleBackColor = false;
			// 
			// btnTimkiem
			// 
			this.btnTimkiem.BackColor = System.Drawing.Color.LightPink;
			this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimkiem.ForeColor = System.Drawing.Color.White;
			this.btnTimkiem.Image = global::bancafe.Properties.Resources.loupe1;
			this.btnTimkiem.Location = new System.Drawing.Point(6, 45);
			this.btnTimkiem.Name = "btnTimkiem";
			this.btnTimkiem.Size = new System.Drawing.Size(121, 93);
			this.btnTimkiem.TabIndex = 5;
			this.btnTimkiem.Text = "Tìm kiếm";
			this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnTimkiem.UseVisualStyleBackColor = false;
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.LightBlue;
			this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLuu.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.White;
			this.btnLuu.Image = global::bancafe.Properties.Resources.save6;
			this.btnLuu.Location = new System.Drawing.Point(109, 19);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(79, 74);
			this.btnLuu.TabIndex = 6;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnLuu.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.LightGreen;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Image = global::bancafe.Properties.Resources.delete__1_;
			this.btnXoa.Location = new System.Drawing.Point(277, 19);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(79, 74);
			this.btnXoa.TabIndex = 5;
			this.btnXoa.Text = "Nghỉ việc";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnXoa.UseVisualStyleBackColor = false;
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.IndianRed;
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSua.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Image = global::bancafe.Properties.Resources.writer1;
			this.btnSua.Location = new System.Drawing.Point(192, 19);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(79, 74);
			this.btnSua.TabIndex = 4;
			this.btnSua.Text = "Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSua.UseVisualStyleBackColor = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.MediumAquamarine;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Image = global::bancafe.Properties.Resources.plus2;
			this.btnThem.Location = new System.Drawing.Point(24, 19);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(79, 74);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnThem.UseVisualStyleBackColor = false;
			// 
			// fnhanvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_craccount);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Name = "fnhanvien";
			this.Size = new System.Drawing.Size(1032, 491);
			this.groupBox5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickernNgaysinh;
        private System.Windows.Forms.RadioButton rdbtnNu;
        private System.Windows.Forms.RadioButton rdbtnNam;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ListView lv_listnv;
        private System.Windows.Forms.Button btn_craccount;
		private System.Windows.Forms.ColumnHeader IDNhanVien;
		private System.Windows.Forms.ColumnHeader TenNhanVien;
		private System.Windows.Forms.ColumnHeader GioiTinh;
		private System.Windows.Forms.ColumnHeader NgaySinh;
		private System.Windows.Forms.ColumnHeader SoDienThoai;
		private System.Windows.Forms.ColumnHeader NgayVaoLam;
		private System.Windows.Forms.ColumnHeader TenBoPhan;
		private System.Windows.Forms.ColumnHeader bTrangthai;
	}
}
