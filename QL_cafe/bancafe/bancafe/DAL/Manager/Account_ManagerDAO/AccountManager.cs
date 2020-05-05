using bancafe.Extension.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancafe.DAL.Account_Manager
{
	class AccountManager
	{
        DataProvider provider = new DataProvider();
        private static AccountManager instance;
        public static AccountManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountManager();
                }
                return instance;
            }
        }
        public bool update(object[] parameter, List<string> listpara)
        {
            int result = provider.ExcuteNoneQuery("Proc_UpdateMatKhau", parameter, listpara);
            if (result != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
