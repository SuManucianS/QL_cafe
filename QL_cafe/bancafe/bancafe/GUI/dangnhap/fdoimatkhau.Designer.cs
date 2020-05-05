namespace bancafe
{
    partial class fdoimatkhau
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fdoimatkhau));
			this.txt_oldpass = new System.Windows.Forms.TextBox();
			this.txt_newpass = new System.Windows.Forms.TextBox();
			this.txt_repass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonThoat = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btnThoat2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_oldpass
			// 
			this.txt_oldpass.Location = new System.Drawing.Point(167, 66);
			this.txt_oldpass.Name = "txt_oldpass";
			this.txt_oldpass.Size = new System.Drawing.Size(193, 23);
			this.txt_oldpass.TabIndex = 0;
			// 
			// txt_newpass
			// 
			this.txt_newpass.Location = new System.Drawing.Point(167, 118);
			this.txt_newpass.Name = "txt_newpass";
			this.txt_newpass.Size = new System.Drawing.Size(193, 23);
			this.txt_newpass.TabIndex = 1;
			// 
			// txt_repass
			// 
			this.txt_repass.Location = new System.Drawing.Point(167, 173);
			this.txt_repass.Name = "txt_repass";
			this.txt_repass.Size = new System.Drawing.Size(193, 23);
			this.txt_repass.TabIndex = 2;
			this.txt_repass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_check);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mật khẩu cũ:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mật khẩu mới:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nhập lại mật khẩu:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::bancafe.Properties.Resources.editpassword1;
			this.pictureBox1.Location = new System.Drawing.Point(412, 59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(204, 193);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// buttonThoat
			// 
			this.buttonThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonThoat.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonThoat.ForeColor = System.Drawing.Color.White;
			this.buttonThoat.Image = global::bancafe.Properties.Resources.delete2;
			this.buttonThoat.Location = new System.Drawing.Point(191, 225);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new System.Drawing.Size(120, 57);
			this.buttonThoat.TabIndex = 7;
			this.buttonThoat.Text = "Thoát";
			this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonThoat.UseVisualStyleBackColor = false;
			this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
			// 
			// btn_update
			// 
			this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_update.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_update.ForeColor = System.Drawing.Color.White;
			this.btn_update.Image = global::bancafe.Properties.Resources.save3;
			this.btn_update.Location = new System.Drawing.Point(64, 225);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(120, 57);
			this.btn_update.TabIndex = 6;
			this.btn_update.Text = "Cập nhật";
			this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_update.UseVisualStyleBackColor = false;
			this.btn_update.Click += new System.EventHandler(this.buttonCapnhat_Click);
			// 
			// btnThoat2
			// 
			this.btnThoat2.BackColor = System.Drawing.Color.Transparent;
			this.btnThoat2.FlatAppearance.BorderSize = 0;
			this.btnThoat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat2.ForeColor = System.Drawing.Color.White;
			this.btnThoat2.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat2.Image")));
			this.btnThoat2.Location = new System.Drawing.Point(602, 12);
			this.btnThoat2.Name = "btnThoat2";
			this.btnThoat2.Size = new System.Drawing.Size(25, 25);
			this.btnThoat2.TabIndex = 9;
			this.btnThoat2.UseVisualStyleBackColor = false;
			// 
			// fdoimatkhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(639, 290);
			this.Controls.Add(this.btnThoat2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonThoat);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_repass);
			this.Controls.Add(this.txt_newpass);
			this.Controls.Add(this.txt_oldpass);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fdoimatkhau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cập nhật mật khẩu";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_oldpass;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.TextBox txt_repass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat2;
    }
}