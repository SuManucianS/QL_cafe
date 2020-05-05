using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancafe.DTO.ManagerDTO
{
	class staff_managerDTO
	{
		private string sIDNV, sTenNV, sSodienthoai, sTenbophan;
		private bool bGioitinh, bTrangthai;
		private DateTime dNgaysinh, dNgayvaolam;
		public staff_managerDTO()
		{
		}

		public staff_managerDTO(string sIDNV, string sTenNV, string sSodienthoai, string sTenbophan, bool bGioitinh, bool bTrangthai, DateTime dNgaysinh, DateTime dNgayvaolam)
		{
			this.SIDNV = sIDNV;
			this.STenNV = sTenNV;
			this.SSodienthoai = sSodienthoai;
			this.STenbophan = sTenbophan;
			this.BGioitinh = bGioitinh;
			this.BTrangthai = bTrangthai;
			this.DNgaysinh = dNgaysinh;
			this.DNgayvaolam = dNgayvaolam;
		}

		public string SIDNV { get => sIDNV; set => sIDNV = value; }
		public string STenNV { get => sTenNV; set => sTenNV = value; }
		public string SSodienthoai { get => sSodienthoai; set => sSodienthoai = value; }
		public string STenbophan { get => sTenbophan; set => sTenbophan = value; }
		public bool BGioitinh { get => bGioitinh; set => bGioitinh = value; }
		public bool BTrangthai { get => bTrangthai; set => bTrangthai = value; }
		public DateTime DNgaysinh { get => dNgaysinh; set => dNgaysinh = value; }
		public DateTime DNgayvaolam { get => dNgayvaolam; set => dNgayvaolam = value; }
	}
}
