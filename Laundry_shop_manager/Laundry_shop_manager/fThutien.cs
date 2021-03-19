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
using System.Text.RegularExpressions;

namespace Laundry_shop_manager
{
    public partial class fThutien : UserControl
    {
        public fThutien()
        {
            InitializeComponent();
            LoadDataGrid();
            this.Load += FThutien_Load;
        }

        private void FThutien_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        void LamMoi()
        {
            txbSHD.Text = "";
            txbTenKhach.Text = "";
            ibtHuyDon.Enabled = false;
        }
        void LoadDataGrid()
        {
            dgvListHoaDon.DataSource = HoaDonDAO.Instance.getListHoaDonThuTien();
        }

        bool checkInfoSearch()
        {
            if(txbTenKhach.Text == "" && txbSHD.Text == "")
            {
                txbTenKhach.Focus();
                return false;
            }
            return true;
        }
        private void dgvListHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txbSHD.Text = dgvListHoaDon.Rows[index].Cells["id_hd"].Value.ToString();
                txbTenKhach.Text = dgvListHoaDon.Rows[index].Cells["tenkh"].Value.ToString();
                ibtHuyDon.Enabled = true;
            }
        }

        private void ibtLamMoiThuTien_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            LamMoi();
        }

        private void ibtThuTien_Click(object sender, EventArgs e)
        {
            if(txbSHD.Text != "")
            {
                string id_hd = txbSHD.Text;
                if(HoaDonDAO.Instance.updateThuTienHoaDon(Convert.ToInt32(id_hd)) > 0)
                {
                    LoadDataGrid();
                    LamMoi();
                    MessageBox.Show("Thu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thu Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ibtTimThuTien_Click(object sender, EventArgs e)
        {
            if (checkInfoSearch())
            {
                string id_hd = txbSHD.Text;
                string tenKh = txbTenKhach.Text;
                if(tenKh != "" && id_hd == "")
                {
                    dgvListHoaDon.DataSource = HoaDonDAO.Instance.timHoaDonTheoTenKhach(tenKh);
                    return;
                }
                if (tenKh == "" && id_hd != "")
                {
                    dgvListHoaDon.DataSource = HoaDonDAO.Instance.timHoaDonTheoID(Convert.ToInt32(id_hd));
                    return;
                }
                dgvListHoaDon.DataSource = HoaDonDAO.Instance.timHoaDonTheoTenKHvaID(tenKh,Convert.ToInt32(id_hd));
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void ibtHuyDon_Click(object sender, EventArgs e)
        {
            if(txbSHD.Text != "")
            {
                if (IsNumber(txbSHD.Text))
                {
                    if(ChiTietHoaDonDAO.Instance.deleteCTHD(Convert.ToInt32(txbSHD.Text)) > 0)
                    {
                        if (HoaDonDAO.Instance.deleteHoaDon(Convert.ToInt32(txbSHD.Text)) > 0)
                        {
                            LoadDataGrid();
                            LamMoi();
                            MessageBox.Show("Hủy đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Không hủy được, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (HoaDonDAO.Instance.deleteHoaDon(Convert.ToInt32(txbSHD.Text)) > 0)
                        {
                            LoadDataGrid();
                            LamMoi();
                            MessageBox.Show("Hủy đơn thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Không hủy được, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số HD phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
