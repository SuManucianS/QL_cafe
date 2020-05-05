using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace bancafe
{
    public partial class forder : Form
    {
        public forder()
        {
            InitializeComponent();
        }

        private string _idnv,_thoigian;

        public forder(string Message, string idnv): this()
        {
            _idnv = idnv;

            _thoigian = Message;
        }

        private void linkLabelThemOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBoxChonDo.Enabled = true;
            groupBoxCTHoaDon.Enabled = true;
            groupBoxChucNang.Enabled = true;
            groupBoxHoaDon.Enabled = true;

        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            fthanhtoan f1 = new fthanhtoan();
            f1.ShowDialog();
            Show();
            linkLabelThemOrder.Enabled = true;
            dataGridViewCTHoaDon.Focus();
            dataGridViewHoaDon.Focus();
            txtSLMon.ResetText();
            txtTongtien.ResetText();
            comboBoxDanhmuc.ResetText();
            comboBoxTenmon.ResetText();
            txtDongia.ResetText();
        }
    }
}
