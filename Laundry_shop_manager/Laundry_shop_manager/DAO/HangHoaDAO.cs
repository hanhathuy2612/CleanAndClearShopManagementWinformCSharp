using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DAO
{
    class HangHoaDAO
    {
        private static HangHoaDAO instance;

        internal static HangHoaDAO Instance
        {
            get { if (instance == null) instance = new HangHoaDAO(); return instance; }
            private set => instance = value; 
        }
        public HangHoaDAO() { }

        public List<HangHoa> GetListHangHoaTheoDM(int id_dm)
        {
            List<HangHoa> listHang = new List<HangHoa>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetHangTheoDanhMuc @id_dm ", new object[] { id_dm});
            foreach(DataRow item in data.Rows)
            {
                HangHoa hang = new HangHoa(item);
                listHang.Add(hang);
            }
            return listHang;
        }

        public DataTable GetListHangHoa()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM HANGHOA");
        }
        
        public DataTable timHangHoaTheoTen(string ten)
        {
            string query = "SELECT * FROM HANGHOA WHERE TenHH like N'%"+ ten +"%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int addHangHoa(HangHoa hd)
        {
            string query = "insert into HANGHOA values( @tenhh , @dongia , @id_dm )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hd.TenHh, hd.DonGia, hd.Id_dm});
        }

        public int updateHangHoa(HangHoa hd)
        {
            string query = "update hanghoa set TenHH = @ten , DonGia = @dongia , id_dm = @id_dm where id_hh = @id_hh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hd.TenHh, hd.DonGia, hd.Id_dm, hd.Id_hh });
        }

        public int deleteHangHoa(HangHoa hh)
        {
            string query = "delete hanghoa where id_hh = @id_hh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hh.Id_hh });
        }
    }
}
