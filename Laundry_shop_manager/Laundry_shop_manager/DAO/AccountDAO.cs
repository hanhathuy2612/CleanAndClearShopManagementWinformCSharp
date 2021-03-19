using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }

        public AccountDAO() { }

        public Account Login(string username, string password)
        {
            string query = "EXEC USP_Login @username , @password ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            if (data.Rows.Count > 0)
            {
                return new Account(data.Rows[0]);
            }
            return new Account();
        }

        public int addAccount(Account ac)
        {
            string query = "INSERT INTO dbo.ACCOUNT( UserName, PassWord, ID_NV )VALUES( @username , @password , @id_nv )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ac.UserName, ac.PassWord, ac.NhanVien.ID});
        }

        public int updateAccount(Account new_ac, Account old_ac)
        {
            string query = "UPDATE ACCOUNT SET USERNAME  = @username , PASSWORD = @password WHERE id_nv = @id_nv";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { new_ac.UserName, new_ac.PassWord, old_ac.NhanVien.ID});
        }

        public DataTable getAccountByNhanVien(NhanVien nv)
        {
            string query = "SELECT * FROM ACCOUNT WHERE id_nv = @id_nv";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { nv.ID });
        }
    }
}
