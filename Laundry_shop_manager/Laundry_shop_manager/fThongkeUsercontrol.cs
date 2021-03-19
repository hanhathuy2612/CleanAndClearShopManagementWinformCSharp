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
using Microsoft.Reporting.WinForms;

namespace Laundry_shop_manager
{
    public partial class fThongkeUsercontrol : UserControl
    {
        public fThongkeUsercontrol()
        {
            InitializeComponent();
        }
        
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable data =  HoaDonDAO.Instance.getListHoaDonBaoCao();
            DataTable tongDT = HoaDonDAO.Instance.TongDoanhThu();
            ReportDataSource rds = new ReportDataSource("ListHoaDon", data);
            ReportDataSource rds2 = new ReportDataSource("TongDoanhThu", tongDT);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }
    }
}
