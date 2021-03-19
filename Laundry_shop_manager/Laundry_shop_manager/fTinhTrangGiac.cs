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
    public partial class fTinhTrangGiac : UserControl
    {
        public fTinhTrangGiac()
        {
            InitializeComponent();
            this.Load += FQuanlydonhang_Load;
            LoadDataGrid();
        }

        private void FQuanlydonhang_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        #region Method
        void LoadDataGrid()
        {
            dgvListHoaDon.DataSource = HoaDonDAO.Instance.getListHoaDonTinhTrangGiac();

        }
        void refreshThongTin()
        {
            txbSoHoaDon.Text = "";
            cbxTrangThaiGiac.Text = "";
            txbSearchSHD.Text = "";
        }
        bool checkThongTin()
        {
            if(txbSoHoaDon.Text == "" || cbxTrangThaiGiac.Text == "")
            {
                txbSoHoaDon.Focus();
                return false;
            }
            return true;
        }
        bool checkThongTinTimKiem()
        {
            if(txbSearchSHD.Text == "")
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Event


        #endregion
        private void fXemhangtonUsercontrol_Load(object sender, EventArgs e)
        {

        }

        private void dgvListHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txbSoHoaDon.Text = dgvListHoaDon.Rows[index].Cells["id_hd"].Value.ToString();
                cbxTrangThaiGiac.Text = dgvListHoaDon.Rows[index].Cells["trangthaigiac"].Value.ToString();
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (checkThongTin())
            {
                int id_hd = Convert.ToInt32(txbSoHoaDon.Text);
                string tinhtranggiac = cbxTrangThaiGiac.Text;
                if (HoaDonDAO.Instance.updateTrangThaiGiacHD(new DTO.HoaDon(id_hd, tinhtranggiac)) > 0)
                {
                    LoadDataGrid();
                    refreshThongTin();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            refreshThongTin();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DateTime ngayNhap = dtpkSearchNgay.Value.Date;
            /*MessageBox.Show(ngayNhap.ToShortDateString());*/
            string id_hd = txbSearchSHD.Text;
            if(id_hd == "")
            {
                dgvListHoaDon.DataSource = HoaDonDAO.Instance.timHoaDonTheoNgay(ngayNhap);
                return;
            }
            dgvListHoaDon.DataSource = HoaDonDAO.Instance.timHoaDonTheoNgayvaSHD(ngayNhap,Convert.ToInt32(id_hd));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
