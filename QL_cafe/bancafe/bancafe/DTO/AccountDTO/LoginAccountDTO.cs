using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancafe.DTO.AccountDTO
{
	class LoginAccountDTO
	{
		private String sUsername, sPassword, sIDNV, sIDBophan;

		public LoginAccountDTO()
		{
		}

		public LoginAccountDTO(string sUsername, string sPassword, string sIDNV, string sIDBophan)
		{
			this.sUsername = sUsername;
			this.sPassword = sPassword;
			this.sIDNV = sIDNV;
			this.sIDBophan = sIDBophan;
		}

		public string SUsername { get => sUsername; set => sUsername = value; }
		public string SPassword { get => sPassword; set => sPassword = value; }
		public string SIDNV { get => sIDNV; set => sIDNV = value; }
		public string SIDBophan { get => sIDBophan; set => sIDBophan = value; }
	}
}
