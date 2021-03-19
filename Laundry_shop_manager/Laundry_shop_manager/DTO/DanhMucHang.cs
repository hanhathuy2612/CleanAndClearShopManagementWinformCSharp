using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DTO
{
    public class DanhMucHang
    {
        private int id_dm;
        private string tenDm;

        public int Id_dm { get => id_dm; set => id_dm = value; }
        public string TenDm { get => tenDm; set => tenDm = value; }

        public DanhMucHang(int id_dm, string tenDm)
        {
            this.id_dm = id_dm;
            this.tenDm = tenDm;
        }
        public DanhMucHang(DataRow row)
        {
            this.id_dm = (int)row["id_dm"];
            this.tenDm = row["tendm"].ToString();
        }
    }
}
