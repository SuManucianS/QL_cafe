using bancafe.DAL.LoginDAO;
using bancafe.Extension.HashSHA256;
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
    public partial class fdangnhap : Form
    {
        public fdangnhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "")
            {
                txtTendangnhap.Focus();
                lb_msusname.Visible = true;
                lb_msusname.Text = "*Hãy điền tài khoản";
            }
            else
                lb_msusname.Visible = false;
            if (txtMatkhau.Text == "")
            {
                txtMatkhau.Focus();
                txtMatkhau.Visible = true;
                lb_mspass.Text = "*Hãy điền mật khẩu";
            }
            else
                lb_mspass.Visible = false;
            string passwordsha = HashSHA256.Hash(txtMatkhau.Text);
            DataTable dt = LoginDAO.Instance.getAccoutLogin(new object[] { txtTendangnhap.Text.Trim(), passwordsha }, new List<string> { "@tendangnhap", "@matkhau" });
            if (dt != null && dt.Rows.Count > 0)
            {

                string sUsername = dt.Rows[0]["Tendangnhan"].ToString();
                string sIDNV = dt.Rows[0]["IDNhanVien"].ToString();
                string sIDbophan = dt.Rows[0]["IDBoPhan"].ToString();
                if (sIDbophan.Equals("BP001") )
                {
                    txtTendangnhap.Text = "";
                    txtMatkhau.Text = "";
                    ftrangchuQL f1 = new ftrangchuQL();
                    f1.sPassword = passwordsha;
                    f1.sUsername = sUsername;
                    Hide();
                    f1.ShowDialog();
                    Show();
                }
                if (!sIDbophan.Equals("BP001"))
                {
                    txtTendangnhap.Text = "";
                    txtMatkhau.Text = "";
                    ftrangchu ftrangchu = new ftrangchu();
                    Hide();
                    ftrangchu.ShowDialog();
                    Show();
                }

            }
            else
            {
                MessageBox.Show("Đăng Nhập Không Thành Công");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                this.Close();
            }
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                this.Close();
            }
        }
    }
}
