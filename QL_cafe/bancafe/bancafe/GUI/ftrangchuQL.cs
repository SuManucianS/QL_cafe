
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancafe
{
    public partial class ftrangchuQL : Form
    {
        public ftrangchuQL()
        {
            InitializeComponent();
        }
        public string sPassword;
        public string sUsername;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                this.Close();
            }
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnNhanvien.Height;
            SidePanel.Top = btnNhanvien.Top;
            fnhanvien1.BringToFront();
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDoanhthu.Height;
            SidePanel.Top = btnDoanhthu.Top;
            fdoanhthu1.BringToFront();
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnNhaphang.Height;
            SidePanel.Top = btnNhaphang.Top;
        }

        private void btnGiaohang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGiaohang.Height;
            SidePanel.Top = btnGiaohang.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThoigian.Text = DateTime.Now.ToString();
        }

        private void ftrangchuQL_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTrangchu.Height;
            SidePanel.Top = btnTrangchu.Top;
            ftrangchuQLHome1.BringToFront();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            fdoimatkhau fchangepass = new fdoimatkhau();
            fchangepass.sPassword = sPassword;
            fchangepass.sUsername = sUsername;
            Hide();
            fchangepass.ShowDialog();
            Show();
            
        }
    }
}
