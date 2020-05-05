using bancafe.Extension.DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancafe.DAL.LoginDAO
{
	class LoginDAO
	{
		DataProvider dtprovider = new DataProvider();
		private static LoginDAO instance;
        public static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginDAO();
                }
                return instance;
            }
        }
        public DataTable getAccoutLogin(object[] parameter, List<String> listparameter)
        {
            DataTable dt = dtprovider.ExcuteQuery("Proc_DangNhap", parameter, listparameter);
            return dt;
        }
    }
}
