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
using System.IO;

namespace Laundry_shop_manager
{
    public partial class fQuanLyNhanVien : UserControl
    {
        string path = Path.GetFullPath("image/");
        public fQuanLyNhanVien()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        #region MeThod

        bool checkThongTinTiemKiem()
        {
            if(txbSearchName.Text == "" && txbSearchSDT.Text == "")
            {
                return false;
            }
            if(txbSearchSDT.Text == "")
            {
                txbSearchSDT.Focus();
            }
            if(txbSearchName.Text == "")
            {
                txbSearchName.Focus();
            }
            return true;
        }
        bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        void refreshThongTin()
        {
            LoadDataGrid();
            txbIdNhanVien.Text = "";
            txbHoVaTen.Text = "";
            txbDiaChi.Text = "";
            cbbChucVu.Text = "";
            txbSDT.Text = "";
            txbSearchName.Text = "";
            txbSearchSDT.Text = "";
            pictureBox1.Image = null;
            lbPathAnhDD.Text = "Chưa có hình";
            txbUserName.Text = "";
            txbIdAccount.Text = "";
            txbPassWord.Text = "";
        }
        bool checkThongTin()
        {
            if(txbHoVaTen.Text == "")
            {
                txbHoVaTen.Focus();
                return false;
            }
            if (txbSDT.Text == "")
            {
                txbSDT.Focus();
                return false;
            }
            if (txbDiaChi.Text == "")
            {
                txbDiaChi.Focus();
                return false;
            }
            if (cbbChucVu.Text == "")
            {
                cbbChucVu.Focus();
                return false;
            }
            if (txbUserName.Text == "")
            {
                txbUserName.Focus();
                return false;
            }
            if (txbPassWord.Text == "")
            {
                txbPassWord.Focus();
                return false;
            }
            if(lbPathAnhDD.Text == "Chưa có ảnh")
            {
                return false;
            }
            return true;
        }
        void LoadDataGrid()
        {
            dgvListNhanVien.DataSource = NhanVienDAO.Instance.getListNhanVien();
            icbtEdit.Enabled = false;
            icbtAdd.Enabled = true;
        }

        bool addNhanVien(NhanVien nv)
        {
            if (NhanVienDAO.Instance.addNhanVien(nv) > 0) {
                return true;
            }
            return false;
        }
        bool updateNhanVien(NhanVien old_nv, NhanVien new_nv)
        {
            if (NhanVienDAO.Instance.updateNhanVien(old_nv, new_nv) > 0)
            {
                return true;
            }
            return false;
        }
        bool deleteNhanVien(NhanVien nv)
        {
            if (NhanVienDAO.Instance.deleteNhanVien(nv) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Event
        private void lbThemTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if(dgvListNhanVien.Rows[index].Cells["id_nv"].Value.ToString() != "")
                {
                    txbIdNhanVien.Text = dgvListNhanVien.Rows[index].Cells["id_nv"].Value.ToString();
                    txbHoVaTen.Text = dgvListNhanVien.Rows[index].Cells["tennv"].Value.ToString();
                    txbSDT.Text = dgvListNhanVien.Rows[index].Cells["sdt"].Value.ToString();
                    txbDiaChi.Text = dgvListNhanVien.Rows[index].Cells["diachi"].Value.ToString();
                    cbbChucVu.Text = dgvListNhanVien.Rows[index].Cells["chuvu"].Value.ToString();
                    dtpkNgaySinh.Text = dgvListNhanVien.Rows[index].Cells["NgaySinh"].Value.ToString();
                    if (dgvListNhanVien.Rows[index].Cells["anhdd"].Value.ToString() != "Chưa có hình")
                    {
                        pictureBox1.Image = new Bitmap(path + dgvListNhanVien.Rows[index].Cells["anhdd"].Value.ToString());
                    }
                    lbPathAnhDD.Text = dgvListNhanVien.Rows[index].Cells["anhdd"].Value.ToString();
                    if (txbIdNhanVien.Text != "")
                    {
                        NhanVien nv = new NhanVien(Convert.ToInt32(txbIdNhanVien.Text));
                        DataTable data = AccountDAO.Instance.getAccountByNhanVien(nv);
                        if (data.Rows.Count > 0)
                        {
                            txbUserName.Text = data.Rows[0].ItemArray[1].ToString();
                            txbPassWord.Text = data.Rows[0].ItemArray[2].ToString();
                            txbIdAccount.Text = data.Rows[0].ItemArray[0].ToString();
                        }
                        else
                        {
                            txbUserName.Text = "";
                            txbPassWord.Text = "";
                            txbIdAccount.Text = "";
                        }
                    }

                    icbtEdit.Enabled = true;
                    icbtAdd.Enabled = true;

                }
               

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpeg: *.jpg; *.png; *.gif; *.bmp;)|*.jpeg: *.jpg; *.png; *.gif; *.bmp;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lbPathAnhDD.Text = openFile.FileName.Replace(path, "");
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }

        }

        #endregion

        private void icbtAdd_Click(object sender, EventArgs e)
        {
            

            if (checkThongTin())
            {
                if (!IsNumber(txbSDT.Text))
                {
                    txbSDT.Focus();
                    MessageBox.Show("Số điện thoại phải toàn số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string userName = txbUserName.Text;
                string passWord = txbPassWord.Text;
                string tenNV = txbHoVaTen.Text;
                int sdt = Convert.ToInt32(txbSDT.Text);
                string diaChi = txbDiaChi.Text;
                string anhDD = lbPathAnhDD.Text;
                DateTime ngaySinh = dtpkNgaySinh.Value;
                string chucVu = cbbChucVu.Text;
                NhanVien nhanVien = new NhanVien(tenNV, chucVu, sdt, diaChi, anhDD, ngaySinh);
                if (addNhanVien(nhanVien))
                {
                    int id_nv = int.Parse(NhanVienDAO.Instance.getNewestNhanVien().Rows[0].ItemArray[0].ToString());
                    NhanVien nvAc = new NhanVien(id_nv);
                    Account account = new Account(userName, passWord, nvAc);
                    if(AccountDAO.Instance.addAccount(account) > 0)
                    {
                        refreshThongTin();
                        MessageBox.Show("Đã thêm", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbtEdit_Click(object sender, EventArgs e)
        {
            if (checkThongTin())
            {
                if (!IsNumber(txbSDT.Text))
                {
                    txbSDT.Focus();
                    MessageBox.Show("Số điện thoại phải toàn số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string userName = txbUserName.Text;
                string passWord = txbPassWord.Text;
                string tenNV = txbHoVaTen.Text;
                int sdt = Convert.ToInt32(txbSDT.Text);
                string diaChi = txbDiaChi.Text;
                string anhDD = lbPathAnhDD.Text;
                DateTime ngaySinh = dtpkNgaySinh.Value;
                string chucVu = cbbChucVu.Text;
                int id_old_nv = Convert.ToInt32(txbIdNhanVien.Text);
                NhanVien new_nv = new NhanVien(tenNV, chucVu, sdt, diaChi, anhDD, ngaySinh);
                NhanVien old_nv = new NhanVien(id_old_nv);
                if (updateNhanVien(old_nv, new_nv))
                {
                    Account new_ac = new Account(userName, passWord);
                    Account old_ac = new Account(old_nv);
                    if (AccountDAO.Instance.updateAccount(new_ac, old_ac) > 0)
                    {
                        refreshThongTin();
                        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Sửa không thành công, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Thông tin không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ibtTimTaiKhoan_Click(object sender, EventArgs e)
        {
            string ten = txbSearchName.Text;
            string sdt = txbSearchSDT.Text;
            if (checkThongTinTiemKiem())
            {
                if(ten!= "" && sdt == "")
                {
                    dgvListNhanVien.DataSource = NhanVienDAO.Instance.timNhanVienTheoTen(ten);
                    return;
                }
                if(ten == "" && sdt != "")
                {
                    if (IsNumber(sdt))
                    {
                        dgvListNhanVien.DataSource = NhanVienDAO.Instance.timNhanVienTheoSDT(Convert.ToInt32(sdt));
                    }
                    else
                    {
                        txbSDT.Focus();
                        MessageBox.Show("Số điện thoại phải toàn số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                dgvListNhanVien.DataSource = NhanVienDAO.Instance.timNhanVienTheoSDTvaTen(Convert.ToInt32(sdt),ten);
            }
            else
            {
                MessageBox.Show("Thông tin tìm kiếm không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void icbtRefresh_Click(object sender, EventArgs e)
        {
            refreshThongTin();
        }
    }
}
