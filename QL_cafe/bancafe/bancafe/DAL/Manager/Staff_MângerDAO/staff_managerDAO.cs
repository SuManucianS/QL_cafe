using bancafe.DTO.ManagerDTO;
using bancafe.Extension.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancafe.DAL.Manager.Staff_MângerDAO
{
	class staff_managerDAO
	{
        DataProvider provider = new DataProvider();
        private static staff_managerDAO instance;
        public static staff_managerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new staff_managerDAO();
                }
                return instance;
            }
        }
        public List<staff_managerDTO> getdatanv(object[] parameter, List<string> listparam)
        {
            List<staff_managerDTO> list_staff = new List<staff_managerDTO>();
            DataTable dt = provider.ExcuteQuery("sp_DSNhanVien", parameter, listparam);
            if (dt != null && dt.Rows.Count > 0)
            {
                staff_managerDTO staff_manage;
                foreach (DataRow row in dt.Rows)
                {

                    string sIDnv = row["IDNhanVien"].ToString();
                    string sTenNhanVien = row["TenNhanVien"].ToString();
                    string sSodienthoai = row["SoDienThoai"].ToString();
                    string stenbophan = row["TenBoPhan"].ToString();
                    bool bGioitinh = bool.Parse(row["GioiTinh"].ToString());
                    bool btrangthai = bool.Parse(row["bTrangthai"].ToString());
                    DateTime dNgaysinh = Convert.ToDateTime(row["NgaySinh"].ToString());
                    DateTime dNgayvaolam = Convert.ToDateTime(row["NgayVaoLam"].ToString());
                    staff_manage = new staff_managerDTO(sIDnv, sTenNhanVien, sSodienthoai, stenbophan, bGioitinh, btrangthai, dNgaysinh, dNgayvaolam);
                    list_staff.Add(staff_manage);
                }
            }
            return list_staff;

        }
    }
}
