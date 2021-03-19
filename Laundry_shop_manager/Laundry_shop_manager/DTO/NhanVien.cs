using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DTO
{
    public class NhanVien
    {
        private int iD;
        private string tenNv;
        private string chucVu;
        private int sDt;
        private string diaChi;
        private string anhDd;
        private DateTime? ngaySinh;

        public int ID { get => iD; set => iD = value; }
        public string TenNv { get => tenNv; set => tenNv = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int SDt { get => sDt; set => sDt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string AnhDd { get => anhDd; set => anhDd = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public NhanVien(int iD, string tenNv, string chucVu, int sDt, string diaChi, string anhDd, DateTime? ngaySinh) : this(iD)
        {
            this.tenNv = tenNv;
            this.chucVu = chucVu;
            this.sDt = sDt;
            this.diaChi = diaChi;
            this.anhDd = anhDd;
            this.ngaySinh = ngaySinh;
        }

        public NhanVien(string tenNv, string chucVu, int sDt, string diaChi = null, string anhDd = null, DateTime? ngaySinh = null)
        {
            this.tenNv = tenNv;
            this.chucVu = chucVu;
            this.sDt = sDt;
            this.diaChi = diaChi;
            this.anhDd = anhDd;
            this.ngaySinh = ngaySinh;
        }

        public NhanVien(int iD)
        {
            this.iD = iD;
        }
        public NhanVien() { }
    }
}
