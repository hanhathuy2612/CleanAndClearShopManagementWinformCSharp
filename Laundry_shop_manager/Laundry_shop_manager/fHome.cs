using Laundry_shop_manager.DAO;
using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_shop_manager
{
    public partial class fHome : Form
    {
        
        /*string path2 = @"C:\Users\ASUS\OneDrive\BTL_C#\Laundry_shop_manager\Laundry_shop_manager\image\";*/
        private static fHome instance;
        /*private int id_nv = 1;*/
        public static fHome Instance 
        {
            get { if (instance == null) instance = new fHome(); return instance; }
            set => instance = value; 
        }
        public fHome()
        {

        }
        public fHome(Account account)
        {
            /*id_nv = account.NhanVien.ID;*/
            InitializeComponent(/*account*/);
            string path = Path.GetFullPath("image/" + account.NhanVien.AnhDd.ToString());
            /*MessageBox.Show(path);*/
            pbxAnhDD.Image = new Bitmap(path);
            lbUserName.Text = account.NhanVien.TenNv.ToString();
            lbChucVu.Text = account.NhanVien.ChucVu.ToString();
            PhanQuyen(account.NhanVien.ChucVu.ToString());
          
        }
        
        #region Method
        
        void PhanQuyen(string chucVu)
        {
            chucVu = chucVu.ToLower();
            if (chucVu.Equals("nhanvien"))
            {
                ibtQuanLyNhanVien.Enabled = false;
                ibtQuanLyMatHang.Enabled = false;
            }
            if (chucVu.Equals("xuong"))
            {
                ibtNhanhang.Enabled = false;
                ibtQuanLyKhachHang.Enabled = false;
                ibtQuanLyNhanVien.Enabled = false;
                icbThutien.Enabled = false;
                ibtThongke.Enabled = false;
                ibtQuanLyMatHang.Enabled = false;
            }
            if (chucVu.Equals("ketoan"))
            {
                ibtNhanhang.Enabled = false;
                ibtQuanLyKhachHang.Enabled = false;
                ibtQuanLyNhanVien.Enabled = false;
                icbThutien.Enabled = false;
                ibtQuanLyDonHang.Enabled = false;
                ibtQuanLyMatHang.Enabled = false;
            }
        }
        #endregion
        #region Event


        private void ibtLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ibtQuanLyMatHang_Click(object sender, EventArgs e)
        {
            fQuanLyMatHang1.BringToFront();
        }
        private void ibt_Click(object sender, EventArgs e)
        {
            fTrangchuUsercontrol1.BringToFront();
        }

        

        private void iconButton2_Click(object sender, EventArgs e)
        {
            fNhanhangUsercontrol1.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            fQuanlydonhang1.BringToFront();
        }

        private void ibtTinhtrangdonhang_Click(object sender, EventArgs e)
        {
            fQuanykhachhang1.BringToFront();
        }

        private void icbThutien_Click(object sender, EventArgs e)
        {
            fThutien1.BringToFront();
        }

        private void ibtQuanlytaikhoan_Click(object sender, EventArgs e)
        {
            fQuanLyNhanVien1.BringToFront();

        }

        private void ibtThongke_Click(object sender, EventArgs e)
        {
            fThongkeUsercontrol1.BringToFront();
        }





        #endregion
    }
}
