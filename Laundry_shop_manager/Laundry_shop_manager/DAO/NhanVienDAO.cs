using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance 
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; } 
            private set => instance = value; 
        }
        public NhanVienDAO() { }
        public int GetTongNhanVien()
        {
            int tong = 0;
            foreach(DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM NHANVIEN").Rows)
            {
                tong++;
            }
            return tong;
        }
        public DataTable getListNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM NHANVIEN");
        }
        public DataTable getNewestNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT max(id_nv) FROM NHANVIEN");
        }

        public int addNhanVien(NhanVien nv)
        {
            string query = "INSERT INTO dbo.NHANVIEN( TenNV, ChuVu, SDT,NgaySinh,DiaChi,AnhDD ) VALUES ( @tenNV , @chucvu , @std , @ngaysinh , @diachi , @anhDD )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { nv.TenNv, nv.ChucVu, nv.SDt, nv.NgaySinh.Value, nv.DiaChi, nv.AnhDd});
        }
        public int updateNhanVien(NhanVien old_nv , NhanVien new_nv)
        {
            string query = "UPDATE dbo.NHANVIEN SET TENNV= @tennv , CHUVU = @chucvu , SDT = @sdt , DIACHI = @diachi , ANHDD = @anhdd WHERE ID_NV = @id_nv";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { new_nv.TenNv, new_nv.ChucVu, new_nv.SDt, new_nv.DiaChi, new_nv.AnhDd, old_nv.ID });
        }
        public int deleteNhanVien(NhanVien nv)
        {
            string query = "DELETE INTO dbo.NHANVIEN WHERE id_nv = @id_nv";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { nv.ID});
        }

        public DataTable timNhanVienTheoTen(string ten)
        {
            string query = "SELECT * FROM NHANVIEN WHERE TENNV like N'%" + ten + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable timNhanVienTheoSDT(int SDT)
        {
            string query = "SELECT * FROM NHANVIEN WHERE SDT like N'%" + SDT + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable timNhanVienTheoSDTvaTen(int SDT, string Ten)
        {
            string query = "SELECT * FROM NHANVIEN WHERE SDT like N'%" + SDT + "%' AND TENNV like N'%" + Ten + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
