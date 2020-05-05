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
    public partial class fthanhtoan : Form
    {
        public fthanhtoan()
        {
            InitializeComponent();
        }
        
        private string _message;

        DataTable data;

        public fthanhtoan(string Message,DataTable dt): this()
        {
            data = dt;
            dataGridViewHDThanhtoan.DataSource = data;

            _message = Message;
            txtTongtien.Text = _message;
        }

        private void buttonThanhtoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            Dispose();
            this.Close();
        }
    }
}
