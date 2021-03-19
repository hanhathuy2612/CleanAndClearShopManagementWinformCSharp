using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DTO
{
    public class HangHoa
    {
        private int id_hh;
        private string tenHh;
        private int donGia;
        private int id_dm;
        public int Id_hh { get => id_hh; set => id_hh = value; }
        public string TenHh { get => tenHh; set => tenHh = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int Id_dm { get => id_dm; set => id_dm = value; }

        public HangHoa(int id_hh, string tenHh, int donGia, int id_dm)
        {
            this.id_hh = id_hh;
            this.tenHh = tenHh;
            this.donGia = donGia;
            this.id_dm = id_dm;
        }
        public HangHoa(string tenHh, int donGia, int id_dm)
        {
            this.tenHh = tenHh;
            this.donGia = donGia;
            this.id_dm = id_dm;
        }
        public HangHoa() { }

        
        public HangHoa(int id_hh)
        {
            this.id_hh = id_hh;
        }

        public HangHoa(DataRow row)
        {
            this.id_hh = Convert.ToInt32(row["id_hh"].ToString());
            this.tenHh = row["tenhh"].ToString();
            this.donGia = Convert.ToInt32( row["dongia"].ToString());
            this.id_dm = Convert.ToInt32(row["id_dm"].ToString());
        }

    }
}
