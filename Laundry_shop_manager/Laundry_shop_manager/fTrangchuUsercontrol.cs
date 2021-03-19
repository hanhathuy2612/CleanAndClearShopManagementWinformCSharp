using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry_shop_manager.DAO;

namespace Laundry_shop_manager
{
    public partial class fTrangchuUsercontrol : UserControl
    {
        public fTrangchuUsercontrol()
        {
            InitializeComponent();
        }
        void LoadHome()
        {
            txbTongNhanVien.Text = NhanVienDAO.Instance.GetTongNhanVien().ToString();
            txbTongDonHang.Text = HoaDonDAO.Instance.GetTongHoaDon().ToString();
            txbTongDoanhThu.Text = HoaDonDAO.Instance.GetTongDoanhThu().ToString();
        }

        private void fTrangchuUsercontrol_Load(object sender, EventArgs e)
        {
            LoadHome();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadHome();
        }
    }
}
