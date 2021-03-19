using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_shop_manager.DTO
{
    public class KhachHang
    {
        private int id_kh;
        private string tenKh;
        private decimal sDt;
        private string diaChi;

        public KhachHang()
        {

        }

        public KhachHang(int id_kh, string tenKh, decimal sDt, string diaChi) : this(id_kh)
        {
            this.tenKh = tenKh;
            this.sDt = sDt;
            this.diaChi = diaChi;
        }

        public KhachHang(string tenKh, decimal sDt, string diaChi)
        {
            
            this.tenKh = tenKh;
            this.sDt = sDt;
            this.diaChi = diaChi;
        }
        public KhachHang(int id_kh)
        {
            this.id_kh = id_kh;
        }

        public int Id_kh { get => id_kh; set => id_kh = value; }
        public string TenKh { get => tenKh; set => tenKh = value; }
        public decimal SDt { get => sDt; set => sDt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
