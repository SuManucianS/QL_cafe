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
    public partial class ftrangchu : Form
    {
        public ftrangchu() 
        {
            InitializeComponent();
        }
        public string sPassword;
        private bool checkFormOpen(string FormName)
        {
            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == FormName)
                {
                    frm.Focus();
                    FormFound = true;
                }
            }
            return FormFound;
        }

        private void orderVàThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderVàThanhToánToolStripMenuItem.ForeColor = Color.Chocolate;
            danhSáchĐồUốngToolStripMenuItem.ForeColor = SystemColors.ControlText;
            đăngXuấtToolStripMenuItem.ForeColor = SystemColors.ControlText;

            bool check = checkFormOpen("order");
            if (check == false)
            {
                forder f1 = new forder();
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void danhSáchĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhSáchĐồUốngToolStripMenuItem.ForeColor = Color.Chocolate;
            orderVàThanhToánToolStripMenuItem.ForeColor = SystemColors.ControlText;
            đăngXuấtToolStripMenuItem.ForeColor = SystemColors.ControlText;

                bool check = checkFormOpen("douong");
                if (check == false)
                {
                    fdouong f1 = new fdouong();
                    f1.MdiParent = this;
                    f1.Show();
                }
        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            //labeltennv1.Text = IDBoPhan + " " + TenNhanVien;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelThoiGian.Text = DateTime.Now.ToString();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                this.Close();

            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = checkFormOpen("doimatkhau");
            if (check == false)
            {
                fdoimatkhau f1 = new fdoimatkhau();
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void đangXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                this.Close();

            }
        }

        
    }
}
