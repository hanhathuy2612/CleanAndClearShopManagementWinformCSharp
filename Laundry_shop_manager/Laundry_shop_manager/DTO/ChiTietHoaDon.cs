using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DTO
{
    public class ChiTietHoaDon
    {
        private int id_cthd;
        private HoaDon hoaDon;
        private HangHoa hangHoa;
        private int soLuong;
        private int thanhTien;

        public ChiTietHoaDon(HoaDon hoaDon, HangHoa hangHoa, int soLuong, int thanhTien)
        {
            
            this.HoaDon = hoaDon;
            this.HangHoa = hangHoa;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }

        public int Id_cthd { get => id_cthd; set => id_cthd = value; }
        public HoaDon HoaDon { get { if (hoaDon == null) hoaDon = new HoaDon(); return hoaDon; } set => hoaDon = value; }
        public HangHoa HangHoa { get { if (hangHoa == null) hangHoa = new HangHoa(); return hangHoa; } set => hangHoa = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
