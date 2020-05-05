using bancafe.DAL.Account_Manager;
using bancafe.Extension.HashSHA256;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancafe.BLL.AccountManagerBLL
{
	class AccountManagerBLL
	{
        private static AccountManagerBLL instance;
        public static AccountManagerBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountManagerBLL();
                }
                return instance;
            }
        }
        public bool checkpass(string txtoldpass, string password)
        {
            if (HashSHA256.Hash(txtoldpass).Equals(password))
                return true;
            else 
                return false;
        }
        public bool checklenghtpass(string txtpass)
        {
            if (txtpass.Length < 8)
            {
                return false;
            }
            else return true;
        }
        public bool checkupdate(object[] parameter, List<string> listpara)
        {
            bool result = AccountManager.Instance.update(parameter, listpara);
            return result;
        }
    }
}
