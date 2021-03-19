using Laundry_shop_manager.DAO;
using Laundry_shop_manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_shop_manager
{
    public partial class fQuanLyMatHang : UserControl
    {
        public fQuanLyMatHang()
        {
            InitializeComponent();
            loadDataGrid();
            clearThongTin();
            cbxDanhMuc.DataSource = DanhMucHangDAO.Instance.GetListDanhMucHang();
            cbxDanhMuc.DisplayMember = "Tendm";
            cbxDanhMuc.ValueMember = "id_dm";
        }
        #region Method
        void loadDataGrid()
        {
            dgvListHang.DataSource = HangHoaDAO.Instance.GetListHangHoa();
        }
        bool checkThongTin()
        {
            if(txbIdHang.Text == "")
            {
                txbIdHang.Focus();
                return false;
            }
            if (txbTenHang.Text == "")
            {
                txbTenHang.Focus();
                return false;
            }
            if (txbGiaTien.Text == "")
            {
                txbGiaTien.Focus();
                return false;
            }
            if (cbxDanhMuc.Text == "")
            {
                cbxDanhMuc.Focus();
                return false;
            }
            return true;
        }
        void clearThongTin()
        {
            txbIdHang.Text = "";
            txbTenHang.Text = "";
            txbGiaTien.Text = "";
            cbxDanhMuc.Text = "";
            txbTimTheoTen.Text = "";
            icbtDelete.Enabled = false;
            ibtUpdate.Enabled = false;
            ibtAdd.Enabled = true;
        }
        #endregion

        #region Event


        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txbIdHang.Text = dgvListHang.Rows[index].Cells["id_hh"].Value.ToString();
                txbTenHang.Text = dgvListHang.Rows[index].Cells["tenhh"].Value.ToString();
                txbGiaTien.Text = dgvListHang.Rows[index].Cells["dongia"].Value.ToString();
                string id_dm = dgvListHang.Rows[index].Cells["id_dm"].Value.ToString();
                DataTable data = DanhMucHangDAO.Instance.getDanhMucTheoID(Convert.ToInt32(id_dm));
                if (data.Rows.Count > 0)
                {
                    cbxDanhMuc.Text = data.Rows[0].ItemArray[1].ToString();
                }
                icbtDelete.Enabled = true;
                ibtUpdate.Enabled = true;
            }
        }

        private void ibtAdd_Click(object sender, EventArgs e)
        {
            if (checkThongTin())
            {
                string tenHh = txbTenHang.Text;
                int donGia = Convert.ToInt32(txbGiaTien.Text);
                string tendm = cbxDanhMuc.Text;
                int id_dm = Convert.ToInt32(DanhMucHangDAO.Instance.getIdBytenDM(tendm).Rows[0].ItemArray[0].ToString());
                HangHoa hh = new HangHoa(tenHh, donGia, id_dm);
                if (HangHoaDAO.Instance.addHangHoa(hh) > 0)
                {
                    loadDataGrid();
                    clearThongTin();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void ibtTim_Click(object sender, EventArgs e)
        {
            string ten = txbTimTheoTen.Text;
            if (ten != "")
            {
                dgvListHang.DataSource = HangHoaDAO.Instance.timHangHoaTheoTen(ten);
            }
        }

        private void icbtRefresh_Click(object sender, EventArgs e)
        {
            loadDataGrid();
            clearThongTin();
        }

        private void fQuanLyMatHang_Load(object sender, EventArgs e)
        {
            clearThongTin();
        }

        private void ibtUpdate_Click(object sender, EventArgs e)
        {
            if (checkThongTin())
            {
                int id_hh = Convert.ToInt32(txbIdHang.Text);
                string tenHh = txbTenHang.Text;
                int donGia = Convert.ToInt32(txbGiaTien.Text);
                string tendm = cbxDanhMuc.Text;
                int id_dm = Convert.ToInt32(DanhMucHangDAO.Instance.getIdBytenDM(tendm).Rows[0].ItemArray[0].ToString());
                HangHoa hh = new HangHoa(id_hh,tenHh, donGia, id_dm);
                if (HangHoaDAO.Instance.updateHangHoa(hh) > 0)
                {
                    loadDataGrid();
                    clearThongTin();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbtDelete_Click(object sender, EventArgs e)
        {
            if (checkThongTin())
            {
                int id_hh = Convert.ToInt32(txbIdHang.Text);
                string tenHh = txbTenHang.Text;
                int donGia = Convert.ToInt32(txbGiaTien.Text);
                string tendm = cbxDanhMuc.Text;
                int id_dm = Convert.ToInt32(DanhMucHangDAO.Instance.getIdBytenDM(tendm).Rows[0].ItemArray[0].ToString());
                HangHoa hh = new HangHoa(id_hh, tenHh, donGia, id_dm);
                if (HangHoaDAO.Instance.deleteHangHoa(hh) > 0)
                {
                    loadDataGrid();
                    clearThongTin();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
