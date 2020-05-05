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
    public partial class fdangki : Form
    {
        public fdangki()
        {
            InitializeComponent();
        }

        private void buttonDangnhap_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }

        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng kí thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                this.Close();

            }
        }
    }
}
