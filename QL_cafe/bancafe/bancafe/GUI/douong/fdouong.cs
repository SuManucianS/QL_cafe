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
    public partial class fdouong : Form
    {
        public fdouong()
        {
            InitializeComponent();
        }

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

        private void buttonThemDM_Click(object sender, EventArgs e)
        {
            bool check = checkFormOpen("danhmuc");
            if (check == false)
            {
                fdanhmuc f1 = new fdanhmuc();
                f1.ShowDialog();
            }
        }
    }
}
