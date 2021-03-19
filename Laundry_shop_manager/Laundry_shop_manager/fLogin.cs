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
    public partial class fLogin : Form
    {
     
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void icbDangnhap_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;
            Account account = AccountDAO.Instance.Login(username, password);
            if (account.ID > 0)
            {
                this.Hide();
                fHome home = new fHome(account);
                home.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("thoát","Thông báo", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
