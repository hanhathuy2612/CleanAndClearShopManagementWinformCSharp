using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DTO
{
    public class HoaDon
    {
        private int id_hd;
        private DateTime? ngayNhap;
        private DateTime? ngayKetThuc;
        private KhachHang khach;
        private NhanVien nhanVien;
        private string express;
        private string chiecKhau;
        private string trangThaiGiac;
        private string trangThaiTT;
        private int tongTien;

        public HoaDon(KhachHang khach, NhanVien nhanVien, string express, string chiecKhau, int tongTien)
        {
            this.khach = khach;
            this.nhanVien = nhanVien;
            this.express = express;
            this.chiecKhau = chiecKhau;
            this.tongTien = tongTien;
        }

        public HoaDon(DataRow row)
        {
            this.id_hd = (int)row["id_hd"];
            this.ngayNhap = (DateTime)row["NgayNhap"];
            this.express = row["express"].ToString();
            this.chiecKhau = row["chietkhau"].ToString();
            this.trangThaiGiac = row["trangthaigiac"].ToString();
        }

        public HoaDon(int id_hd)
        {
            this.id_hd = id_hd;
        }

        public HoaDon(int id_hd, string trangThaiGiac) : this(id_hd)
        {
            this.trangThaiGiac = trangThaiGiac;
        }

        public HoaDon() { }

        public int Id_hd { get => id_hd; set => id_hd = value; }
        public DateTime? NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public DateTime? NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public KhachHang Khach { get { if (khach == null) khach = new KhachHang();return khach; } set => khach = value; }
        public NhanVien NhanVien { get { if (nhanVien == null) nhanVien = new NhanVien(); return nhanVien; } set => nhanVien = value; }
        public string Express { get => express; set => express = value; }
        public string ChiecKhau { get => chiecKhau; set => chiecKhau = value; }
        public string TrangThaiGiac { get => trangThaiGiac; set => trangThaiGiac = value; }
        public string TrangThaiTT { get => trangThaiTT; set => trangThaiTT = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
