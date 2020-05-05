using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bancafe.DTO.ManagerDTO;
using bancafe.DAL.Manager.Staff_MângerDAO;

namespace bancafe
{
    public partial class fnhanvien : UserControl
    {
        public fnhanvien()
        {
            InitializeComponent();
            loadlistviewstaff();
        }
        List<staff_managerDTO> list_staff;
        private void loadlistviewstaff()
        {
            lv_listnv.Items.Clear();
            list_staff = staff_managerDAO.Instance.getdatanv(null, null);
            ListViewItem item;
            foreach (staff_managerDTO staff in list_staff)
            {
                item = new ListViewItem();
                item.Text = staff.SIDNV.ToString();
                item.SubItems.Add(staff.STenNV.ToString());
                item.SubItems.Add(staff.BGioitinh == true ? "Nam" : "Nu");
                item.SubItems.Add(staff.DNgaysinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(staff.SSodienthoai.ToString());
                item.SubItems.Add(staff.DNgayvaolam.ToString("dd/MM/yyyy"));
                item.SubItems.Add(staff.STenbophan.ToString());
                item.SubItems.Add(staff.BTrangthai == true ? "dang di lam" : "da nghi lam");
                lv_listnv.Items.Add(item);
            }
        }
    }
}
