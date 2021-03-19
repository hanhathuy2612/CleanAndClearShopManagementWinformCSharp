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
using Laundry_shop_manager.DTO;
using System.Text.RegularExpressions;

namespace Laundry_shop_manager
{
    public partial class fQuanykhachhang : UserControl
    {
        public fQuanykhachhang()
        {
            InitializeComponent();
            loadDataGrid();
        }
        
        #region Method
        void loadDataGrid()
        {
            dataGridView1.DataSource = KhachHangDAO.Instance.getListKhachHang();
            setDefaultButton();
        }
        void setDefaultButton()
        {
            ibtAdd.Enabled = true;
            ibtUpdate.Enabled = false;
        }
        void setDefaultKhach()
        {
            txbIdKhach.Text = "";
            txbTenKhachHang.Text = "";
            txbSoDienThoaiKH.Text = "";
            txbDiaChi.Text = "";
            txbTimKiemTheoTen.Text = "";
            txbTimTheoSDTKH.Text = "";
        }
        bool checkThongTinTimKiem()
        {
            if(lbten.Text == "" && txbTimTheoSDTKH.Text == "")
            {
                lbten.Focus();
                return false;
            }  
            return true;
        }
        bool checkThongTinKhach()
        {
            if(txbTenKhachHang.Text == "")
            {
                txbTenKhachHang.Focus();
                return false;
            }
            if (txbSoDienThoaiKH.Text == "")
            {
                txbSoDienThoaiKH.Focus();
                return false;
            }
            if (txbDiaChi.Text == "")
            {
                txbDiaChi.Focus();
                return false;
            }
            return true;
        }
        bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        bool addKhachhang(KhachHang kh)
        {
            if(KhachHangDAO.Instance.addKhachHang(kh) > 0)
            {
                return true;
            }
            return false;
        }

        bool updateKhachHang(KhachHang old_kh, KhachHang new_kh)
        {
            if (KhachHangDAO.Instance.updateKhachHang(old_kh, new_kh) > 0)
            {
                return true;
            }
            return false;
        }
       /* bool deleteKhachHang(KhachHang kh)
        {
            if (KhachHangDAO.Instance.deleteKhachHang(kh) > 0)
            {
                return true;
            }
            return false;
        }*/
        #endregion

        #region Event
        private void fQuanykhachhang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int index = e.RowIndex;
            if(index >=0)
            {
                txbIdKhach.Text = dataGridView1.Rows[index].Cells["id_kh"].Value.ToString();
                txbTenKhachHang.Text = dataGridView1.Rows[index].Cells["TenKH"].Value.ToString();
                txbSoDienThoaiKH.Text = dataGridView1.Rows[index].Cells["SDT"].Value.ToString();
                txbDiaChi.Text = dataGridView1.Rows[index].Cells["DIACHI"].Value.ToString();
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txbIdKhach.Text = dataGridView1.Rows[index].Cells["id_kh"].Value.ToString();
                txbTenKhachHang.Text = dataGridView1.Rows[index].Cells["TenKH"].Value.ToString();
                txbSoDienThoaiKH.Text = dataGridView1.Rows[index].Cells["SDT"].Value.ToString();
                txbDiaChi.Text = dataGridView1.Rows[index].Cells["DIACHI"].Value.ToString();
            }
            ibtAdd.Enabled = true;
            ibtUpdate.Enabled = true;
        }

        #endregion

        private void ibtAdd_Click(object sender, EventArgs e)
        {
            if (checkThongTinKhach())
            {
                if (!IsNumber(txbSoDienThoaiKH.Text))
                {
                    txbSoDienThoaiKH.Focus();
                    MessageBox.Show("Số điện thoại phải toàn số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string tenKH = txbTenKhachHang.Text;
                int sDt = Convert.ToInt32(txbSoDienThoaiKH.Text);
                string diaChi = txbDiaChi.Text;

                KhachHang kh = new KhachHang(tenKH, sDt, diaChi);
                if (addKhachhang(kh))
                {
                    loadDataGrid();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm không được, xin vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ibtUpdate_Click(object sender, EventArgs e)
        {
            if (checkThongTinKhach())
            {
                if (!IsNumber(txbSoDienThoaiKH.Text))
                {
                    txbSoDienThoaiKH.Focus();
                    MessageBox.Show("Số điện thoại phải toàn số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id_kh = Convert.ToInt32(txbIdKhach.Text);
                string tenKH = txbTenKhachHang.Text;
                int sDt = Convert.ToInt32(txbSoDienThoaiKH.Text);
                string diaChi = txbDiaChi.Text;
                KhachHang old_kh = new KhachHang(id_kh);
                KhachHang new_kh = new KhachHang(tenKH, sDt, diaChi);
                if (updateKhachHang(old_kh, new_kh))
                {
                    loadDataGrid();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sửa không được, xin vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void ibtDelete_Click(object sender, EventArgs e)
        {
            if (checkThongTinKhach())
            {
                int id_kh = Convert.ToInt32(txbIdKhach.Text);
                string tenKH = txbTenKhachHang.Text;
                int sDt = Convert.ToInt32(txbSoDienThoaiKH.Text);
                string diaChi = txbDiaChi.Text;

                KhachHang kh = new KhachHang(id_kh,tenKH, sDt, diaChi);
                if (deleteKhachHang(kh))
                {
                    loadDataGrid();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xóa không được, xin vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void icbtRefresh_Click(object sender, EventArgs e)
        {
            loadDataGrid();
            setDefaultKhach();
           
        }

        private void ibtSearch_Click(object sender, EventArgs e)
        {
            string tenkh = txbTimKiemTheoTen.Text;
            string sdt = txbTimTheoSDTKH.Text;
            if (checkThongTinTimKiem())
            {
                if (!IsNumber(txbTimTheoSDTKH.Text) && txbTimTheoSDTKH.Text != "")
                {
                    txbTimTheoSDTKH.Focus();
                    MessageBox.Show("Số điện thoại phải toàn số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if(tenkh == "" && sdt != "")
                    {
                        dataGridView1.DataSource = KhachHangDAO.Instance.timKhachHangTheoSDT(Convert.ToInt32(sdt));
                        return;
                    }
                    if(tenkh != "" && sdt == "")
                    {
                        dataGridView1.DataSource = KhachHangDAO.Instance.timKhachHangTheoTen(tenkh);
                        return;
                    }
                    dataGridView1.DataSource = KhachHangDAO.Instance.timKhachHangTheoSDTvaTen(Convert.ToInt32(sdt), tenkh);
                }
            }
            else
            {
                MessageBox.Show("Thông không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
