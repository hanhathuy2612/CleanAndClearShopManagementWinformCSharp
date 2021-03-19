using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DAO
{
    class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        internal static ChiTietHoaDonDAO Instance 
        { 
            get { if (instance == null) instance = new ChiTietHoaDonDAO(); return instance; } 
            private set => instance = value; 
        }
        public ChiTietHoaDonDAO() { }

        public int addChiTietHoaDon(ChiTietHoaDon cthd)
        {
            string query = "insert into CHITIETHD values( @id_hd , @id_hh , @soluong , @thanhtien )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { cthd.HoaDon.Id_hd, cthd.HangHoa.Id_hh, cthd.SoLuong, cthd.ThanhTien });
        }
        public int deleteCTHD(int id_hd)
        {
            string query = "DELETE CHITIETHD WHERE id_hd = @id_hd";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_hd});
        }
    }
}
