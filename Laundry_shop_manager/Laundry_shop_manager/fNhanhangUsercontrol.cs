using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry_shop_manager.DTO;
using Laundry_shop_manager.DAO;
using System.Text.RegularExpressions;

namespace Laundry_shop_manager
{
    public partial class fNhanhangUsercontrol : UserControl
    {
        public fNhanhangUsercontrol()
        {
            InitializeComponent();
            loadDanhMuc();
            txbIdNhanVien.Text = "1";
            loadKhachHang();
        }

        
        #region Method
        void loadDanhMuc()
        {
            icbtnBack.Enabled = false;
            flowLayoutPanelButtonNhap.Controls.Clear();
            foreach (DanhMucHang item in DanhMucHangDAO.Instance.GetListDanhMucHang())
            {
                Button btn = new Button();
                btn.Tag = item;
                btn.Size = new System.Drawing.Size(138, 46);
                btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                btn.Text = item.TenDm;
                btn.Click += Btn_Click;
                flowLayoutPanelButtonNhap.Controls.Add(btn);
            }
        }
        void loadKhachHang()
        {
            dgvLishKhachHang.DataSource = KhachHangDAO.Instance.getListKhachHang();
        }
        void clearNhanhang()
        {
            lsvHangHoa.Items.Clear();
            txbTongTien.Text = "0";
            txtExpress.Text = "";
            txbThanhTien.Text = "0";
            comboBox1.Text = "";
            txbSdtKhach.Text = "";
            txbTenKhach.Text = "";
            txbDiaChi.Text = "";
        }

        bool ThemHoaDon(HoaDon hd)
        {
            if(HoaDonDAO.Instance.addHoaDon(hd) > 0)
            {
                return true;
            }
            return false;
        }

        bool ThemCTHD(ChiTietHoaDon cthd)
        {
            if (ChiTietHoaDonDAO.Instance.addChiTietHoaDon(cthd) > 0)
            {
                return true;
            }
            return false;
        }
        bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        bool checkInfo()
        {
            if(txbTenKhach.Text == "" || txbSdtKhach.Text == "" || txbDiaChi.Text == "")
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsNumber(txbSdtKhach.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            icbtnBack.Enabled = true;
            DanhMucHang danhMuc = (sender as Button).Tag as DanhMucHang;
            flowLayoutPanelButtonNhap.Controls.Clear();
            foreach (HangHoa item in HangHoaDAO.Instance.GetListHangHoaTheoDM(danhMuc.Id_dm))
            {
                Button btn = new Button();
                btn.Tag = item;
                btn.Size = new System.Drawing.Size(138, 46);
                btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                btn.Text = item.TenHh;
                btn.Click += Btn_Click1;
                flowLayoutPanelButtonNhap.Controls.Add(btn);
            }

        }
        private void Btn_Click1(object sender, EventArgs e)
        {
            int soluong = 1;
            int tongTien = Convert.ToInt32(txbTongTien.Text);
            int thanhTien = Convert.ToInt32(txbThanhTien.Text);
            HangHoa hang = (sender as Button).Tag as HangHoa;

            foreach (ListViewItem itemhangHang in lsvHangHoa.Items)
            {
                if (itemhangHang.SubItems[1].Text.Equals(hang.TenHh.ToString()))
                {
                    int soluong2 = Convert.ToInt32(itemhangHang.SubItems[3].Text) + 1;
                    itemhangHang.SubItems[3].Text = soluong2.ToString();
                    tongTien += hang.DonGia;
                    thanhTien += hang.DonGia;
                    txbTongTien.Text = tongTien.ToString();
                    txbThanhTien.Text = thanhTien.ToString();
                    return;
                }
            }
            ListViewItem item = new ListViewItem(hang.Id_hh.ToString());
            item.SubItems.Add(hang.TenHh.ToString());
            item.SubItems.Add(hang.DonGia.ToString());
            item.SubItems.Add(soluong.ToString());
            tongTien += hang.DonGia;
            thanhTien += hang.DonGia;
            lsvHangHoa.Items.Add(item);
            txbTongTien.Text = tongTien.ToString();
            txbThanhTien.Text = thanhTien.ToString();
        }



        private void icbtnBack_Click(object sender, EventArgs e)
        {
            loadDanhMuc();
        }

        private void ibtExpress_Click(object sender, EventArgs e)
        {
            int express = 30;
            int chieckhau = 0;
            if (comboBox1.Text != "")
            {
                string[] phanTram = comboBox1.Text.ToString().Split('%');
                chieckhau = Convert.ToInt32(txbTongTien.Text) * Convert.ToInt32(phanTram[0]) / 100;
            }
            if (!txtExpress.Text.Equals("30%"))
            {
                txtExpress.Text = express + "%";
                int tong = Convert.ToInt32(txbTongTien.Text);
                int thanhtien = tong + tong * 30 / 100 - chieckhau;
                txbThanhTien.Text = thanhtien.ToString();
            }
            else
            {
                txtExpress.Text = "";
                int tong = Convert.ToInt32(txbThanhTien.Text);
                int phanTram = Convert.ToInt32(txbTongTien.Text) * 30 / 100;
                int thanhtien = tong - phanTram;
                txbThanhTien.Text = thanhtien.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string[] phanTramSo = comboBox.Text.ToString().Split('%');

            if (!txtExpress.Text.Equals("30%"))
            {
                int tong = Convert.ToInt32(txbTongTien.Text);
                int tinhPhanTram = Convert.ToInt32(txbTongTien.Text) * Convert.ToInt32(phanTramSo[0]) / 100;
                int thanhtien = tong - tinhPhanTram;
                txbThanhTien.Text = thanhtien.ToString();
            }
            else
            {
                int tong = Convert.ToInt32(txbTongTien.Text) + Convert.ToInt32(txbTongTien.Text) * 30 / 100;
                int tinhPhanTram = Convert.ToInt32(txbTongTien.Text) * Convert.ToInt32(phanTramSo[0]) / 100;
                int thanhtien = tong - tinhPhanTram;
                txbThanhTien.Text = thanhtien.ToString();
            }
        }

        private void lsvHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ListViewItem item = sender as ;
            MessageBox.Show(item.SubItems[0].Text);*/
        }

        private void itbHuy_Click(object sender, EventArgs e)
        {
            /*int chienKhau = 0;
            int express = 0;
            if(txtExpress.Text.Equals("30%"))
            {
                express = Convert.ToInt32(txbTongTien.Text) * 30 / 100;
            }
            if (!comboBox1.Text.Equals(""))
            {
                string[] phanTramSo = comboBox1.Text.ToString().Split('%');
                chienKhau = Convert.ToInt32(txbTongTien.Text) * Convert.ToInt32(phanTramSo[0]) / 100;
            }
            foreach(ListViewItem item in lsvHangHoa.Items)
            {
                if(item.Checked == true)
                {
                    lsvHangHoa.Items.Remove(item);
                    int tongTien = Convert.ToInt32(txbTongTien.Text) - Convert.ToInt32(item.SubItems[2].Text) * Convert.ToInt32(item.SubItems[3].Text);
                    int thanhTien = tongTien + express - chienKhau;
                    txbThanhTien.Text = thanhTien.ToString();
                    txbTongTien.Text = tongTien.ToString();
                }
            }*/
            clearNhanhang();
        }
        private void ibtLuuNhanHang_Click(object sender, EventArgs e)
        {
            /*int tongTien = Convert.ToInt32( txbTongTien.Text);*/
            int thanhTien = Convert.ToInt32(txbThanhTien.Text);
            string express = txtExpress.Text;
            string chiecKhau = comboBox1.Text;

            NhanVien nhanVien = new NhanVien(Convert.ToInt32(txbIdNhanVien.Text));
            KhachHang khachHang = null;

            if (checkInfo())
            {
                int id_kh = KhachHangDAO.Instance.GetIdKhach(txbTenKhach.Text, int.Parse(txbSdtKhach.Text), txbDiaChi.Text);
                if(id_kh != -1)
                {
                   khachHang = new KhachHang(id_kh);
                }
                else
                {
                    /*MessageBox.Show(Convert.ToInt32(txbSdtKhach.Text).ToString());*/
                    khachHang = new KhachHang(txbTenKhach.Text, Convert.ToDecimal(txbSdtKhach.Text), txbDiaChi.Text);
                    KhachHangDAO.Instance.addKhachHang(khachHang);

                    khachHang = new KhachHang(KhachHangDAO.Instance.GetIdKhach(txbTenKhach.Text, Convert.ToInt32(txbSdtKhach.Text), txbDiaChi.Text));
                }
                HoaDon hd = new HoaDon(khachHang, nhanVien, express, chiecKhau, thanhTien);
                if (ThemHoaDon(hd))
                {
                    int newestIdHd = HoaDonDAO.Instance.GetNewestIdHD();

                    foreach(ListViewItem item in lsvHangHoa.Items)
                    {
                        HoaDon hd2 = new HoaDon(newestIdHd);
                        HangHoa hang = new HangHoa(Convert.ToInt32(item.SubItems[0].Text));
                        int thanhTien2 = Convert.ToInt32(item.SubItems[3].Text) * Convert.ToInt32(item.SubItems[2].Text);
                        ChiTietHoaDon cthd = new ChiTietHoaDon(hd2,hang,Convert.ToInt32(item.SubItems[3].Text),thanhTien2);
                        if (!ThemCTHD(cthd))
                        {
                            MessageBox.Show("Lưu không thành công, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearNhanhang();
                }
                else
                {
                    MessageBox.Show("Lưu không thành công, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fNhanhangUsercontrol_Load(object sender, EventArgs e)
        {
            
        }

        private void txbSearchTenKhach_TextChanged(object sender, EventArgs e)
        {

            string chuoi = txbSearchTenKhach.Text;
            if(chuoi != "")
            {
                dgvLishKhachHang.DataSource = KhachHangDAO.Instance.timKhachHang(chuoi);
            }
            else
            {
                loadKhachHang();
            }
        }

        private void dgvLishKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txbTenKhach.Text = dgvLishKhachHang.Rows[index].Cells["tenkh"].Value.ToString();
                txbSdtKhach.Text = dgvLishKhachHang.Rows[index].Cells["sdt"].Value.ToString();
                txbDiaChi.Text = dgvLishKhachHang.Rows[index].Cells["diachi"].Value.ToString();
            }
        }

        /*  bool checkThongTinTimKiem()
          {
              if(txbTenKhach.Text == "")
              {
                  txbTenKhach.Focus();
                  return false;
              }
              if(txbDiaChi.Text == "")
              {
                  txbDiaChi.Focus();
                  return false;
              }
              if(txbSdtKhach.Text == "")
              {
                  txbSdtKhach.Focus();
                  return false;
              }
              return true;
          }*/

    }
    #endregion


}
