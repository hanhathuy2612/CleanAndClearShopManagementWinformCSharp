using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;
        internal static HoaDonDAO Instance 
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set => instance = value; 
        }
        public HoaDonDAO() { }

        /// <summary>
        /// ADD, DELETE, UPDATE
        /// </summary>
        /// <param name="hd"></param>
        /// <returns></returns>
        #region add, delete, update
        public int updateTrangThaiGiacHD(HoaDon hd)
        {
            string query = "UPDATE dbo.HOADON SET TrangThaiGiac = @TrangThaiGiac WHERE ID_HD = @id_hd";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hd.TrangThaiGiac, hd.Id_hd });
        }
        public int updateThuTienHoaDon(int id_hd)
        {
            string query = "UPDATE dbo.HOADON SET TrangThaiTT = N'Xong', NgayKetThuc = GETDATE() WHERE ID_HD = @id_hd";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_hd });
        }
        public int addHoaDon(HoaDon hd)
        {
            string query = "insert into HOADON values(GETDATE(), null, @id_kh , @id_nv , @tongtien , @express , @chieckhau ,N'Chưa xong', N'Chưa thanh toán')";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hd.Khach.Id_kh, hd.NhanVien.ID, hd.TongTien, hd.Express, hd.ChiecKhau });
        }
        public int deleteHoaDon(int id)
        {
            string query = "DELETE HOADON WHERE id_hd = @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        #endregion
        
        /// <summary>
        /// TÌNH TRẠNG GIẶC
        /// </summary>
        /// <returns></returns>
        #region Tình trạng giặc
        public DataTable getListHoaDonTinhTrangGiac()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT ID_HD,NgayNhap,Express,ChietKhau,TrangThaiGiac FROM dbo.HOADON WHERE TrangThaiTT != N'Xong'");
        }
        public DataTable timHoaDonTheoNgay(DateTime ngay)
        {
            string query = "SELECT ID_HD,NgayNhap,Express,ChietKhau,TrangThaiGiac FROM dbo.HOADON WHERE NgayNhap = @ngay AND TrangThaiTT != N'Xong'";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ngay });
        }
        public DataTable timHoaDonTheoNgayvaSHD(DateTime ngay, int shd)
        {
            string query = "SELECT ID_HD,NgayNhap,Express,ChietKhau,TrangThaiGiac FROM dbo.HOADON WHERE NgayNhap = @ngay AND id_hd = @id_hd AND TrangThaiTT != N'Xong'";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ngay, shd });
        }

        #endregion
        public int GetTongHoaDon()
        {
            int tong = 0;
            foreach (DataRow item in DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON").Rows)
            {
                tong++;
            }
            return tong;
        }
        public decimal GetTongDoanhThu()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT SUM(TongTien) FROM dbo.HOADON WHERE TrangThaiTT = N'Xong'");
            if(data.Rows.Count > 0 && data.Rows[0].ItemArray[0].ToString() != "")
            {

                return Convert.ToDecimal(data.Rows[0].ItemArray[0].ToString());
            }
            return 0;
        }
        public DataTable TongDoanhThu()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT SUM(TongTien) FROM dbo.HOADON WHERE TrangThaiTT = N'Xong'");
        }
        public DataTable getListHoaDonBaoCao()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADON WHERE TrangThaiTT = N'Xong'");
        }

        public DataTable getListHoaDon()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADON");
        }
       
        public DataTable getListHoaDonThuTien()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_GetListHoaDonThuTien");
        }

        
        public int GetNewestIdHD()
        {
            string query = "select max(id_hd) as 'id HD' from HOADON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if(data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0].ItemArray[0].ToString());
            }
            return -1;
        }
        
        
        public DataTable timHoaDonTheoTenKhach(string ten)
        {
            string query = "EXEC USP_timKiemHoaDonThuTienTheoTen @ten";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ten });
        }
        public DataTable timHoaDonTheoID(int id)
        {
            string query = "EXEC USP_timKiemHoaDonThuTienTheoID @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
        public DataTable timHoaDonTheoTenKHvaID(string ten, int id)
        {
            string query = "EXEC USP_timKiemHoaDonThuTienTheoIDvaTEN @id , @ten ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id,ten });
        }

       
    }
}
