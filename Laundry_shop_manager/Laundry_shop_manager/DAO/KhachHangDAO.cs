using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        internal static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set => instance = value;
        }
        public KhachHangDAO() { }

        public DataTable getListKhachHang()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.KHACHHANG");
        }
        public int GetIdKhach(string tenKhach, int sdt, string diaChi)
        {
            string query = "select id_kh from KHACHHANG where tenKh = @tenKH AND sdt = @sdt AND diaChi = @diaChi ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenKhach, sdt, diaChi });
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0].ItemArray[0].ToString());
            }
            return -1;
        }
        public int addKhachHang(KhachHang kh)
        {
            string query = "insert into KHACHHANG(tenkh,sdt,diachi) values( @tenKH , @sdt , @diachi )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { kh.TenKh, Convert.ToInt32(kh.SDt), kh.DiaChi });
        }
        public int updateKhachHang(KhachHang old_kh, KhachHang new_kh)
        {
            string query = "UPDATE KHACHHANG SET TenKH = @tenkh , SDT = @sdt , DIACHI = @diachi where id_kh = @id_kh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { new_kh.TenKh, new_kh.SDt, new_kh.DiaChi, old_kh.Id_kh });
        }
        public int deleteKhachHang(KhachHang kh)
        {
            string query = "DELETE KHACHHANG WHERE id_kh = @id_kh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { kh.Id_kh});
        }

        public DataTable timKhachHangTheoTen(string ten)
        {
            string query = "SELECT * FROM KHACHHANG WHERE TENKH like N'%" + ten+ "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable timKhachHangTheoSDT(int SDT)
        {
            string query = "SELECT * FROM KHACHHANG WHERE SDT like N'%" + SDT + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable timKhachHangTheoSDTvaTen(int SDT, string Ten)
        {
            string query = "SELECT * FROM KHACHHANG WHERE SDT like N'%" + SDT + "%' AND TENKH like N'%" + Ten + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable timKhachHang(string chuoi)
        {
            string query = "SELECT * FROM KHACHHANG WHERE SDT like N'%" + chuoi + "%' OR TENKH like N'%" + chuoi + "%' OR DIACHI like N'%" + chuoi + "%'";
                /*"OR DIACHI like N'%" + chuoi + "%' OR id_kh = " + chuoi;*/
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
