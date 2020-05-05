using bancafe.BLL.AccountManagerBLL;
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
    public partial class fdoimatkhau : Form
    {
        public fdoimatkhau()
        {
            InitializeComponent();
        }

        public string sPassword;
        public string sUsername; 
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                this.Close();
            }
        }

        private void buttonCapnhat_Click(object sender, EventArgs e)
        {
            bool result = AccountManagerBLL.Instance.checkpass(txt_oldpass.Text.ToString().Trim(), sPassword);
            bool leght_pass = AccountManagerBLL.Instance.checklenghtpass(txt_newpass.Text);
            object[] parameter = new object[] { sUsername,HashSHA256.Hash(txt_newpass.Text.ToString().Trim()) };
            List<String> listpara = new List<string> { "@tendangnhap", "@matkhau" };
            
            if (leght_pass == true && result == true)
            {
                bool reuslt_update = AccountManagerBLL.Instance.checkupdate(parameter, listpara);
                if (reuslt_update == true)
                {
                    MessageBox.Show("Update success");
                    txt_oldpass.Text = "";
                    txt_newpass.Text = "";
                    txt_repass.Text = "";
                }
                else
                {
                    MessageBox.Show("Update false");
                }
            }
            else
            {
                MessageBox.Show("xem lai thong tin");
            }
        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void txt_check(object sender, KeyEventArgs e)
        {
            string newpass = txt_newpass.Text.ToString().Trim();
            string repass = txt_repass.Text.ToString().Trim();
            if (repass.Equals(newpass) == false)
            {
                errorProvider.SetError(txt_repass, "Mật Khẩu Không Trùng Khớp");
                btn_update.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btn_update.Enabled = true;
            }
        }
    }
}
