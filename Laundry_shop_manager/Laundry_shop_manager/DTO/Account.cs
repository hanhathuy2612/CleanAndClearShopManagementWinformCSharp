using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DTO
{
    public class Account
    {
        private int iD;
        private string userName;
        private string passWord;
        private NhanVien nhanVien;

        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public NhanVien NhanVien
        {
            get { if (nhanVien == null) nhanVien = new NhanVien(); return nhanVien; }
            set => nhanVien = value;
        }

        public Account()
        {
            this.iD = 0;
        }

        public Account(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }

        public Account(int iD, string userName, string passWord, NhanVien nhanVien)
        {
            this.iD = iD;
            this.userName = userName;
            this.passWord = passWord;
            this.NhanVien = nhanVien;
        }

        public Account(string userName, string passWord, NhanVien nhanVien)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.nhanVien = nhanVien;
        }
        public Account(NhanVien nv)
        {
            this.nhanVien = nv;
        }
        public Account(DataRow row)
        {
            this.iD = (int)row["id_ac"];
            this.NhanVien.ID = (int)row["ID_NV"];
            this.NhanVien.TenNv = row["tennv"].ToString();
            this.NhanVien.AnhDd = row["anhdd"].ToString();
            this.NhanVien.ChucVu = row["chuvu"].ToString();

        }
    }
}
