using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DAO
{
    class DanhMucHangDAO
    {
        private static DanhMucHangDAO instance;

        internal static DanhMucHangDAO Instance
        { 
            get { if (instance == null) instance = new DanhMucHangDAO(); return instance; }
            private set => instance = value; 
        }
        public DanhMucHangDAO() { }

        public List<DanhMucHang> GetListDanhMucHang()
        {
            List<DanhMucHang> listDanhMuc = new List<DanhMucHang>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DANHMUCHANG");
            foreach(DataRow item in data.Rows)
            {
                DanhMucHang dmh = new DanhMucHang(item);
                listDanhMuc.Add(dmh);
            }
            return listDanhMuc;
        }

        public DataTable getDanhMucTheoID(int id)
        {
            return DataProvider.Instance.ExecuteQuery("select * from DANHMUCHANG WHERE id_dm = @id", new object[] { id});
        }

        public DataTable getIdBytenDM(string ten)
        {
            string query = "select id_dm from danhmuchang where tendm = @ten";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ten });
        }
    }
}
