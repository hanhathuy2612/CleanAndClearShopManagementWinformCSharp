namespace Laundry_shop_manager
{
    partial class fThongkeUsercontrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SHOP_GIAC_UIDataSet4 = new Laundry_shop_manager.SHOP_GIAC_UIDataSet4();
            this.USP_GetTotal_NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SHOP_GIAC_UIDataSet = new Laundry_shop_manager.SHOP_GIAC_UIDataSet();
            this.USP_GetTotal_NhanVienTableAdapter = new Laundry_shop_manager.SHOP_GIAC_UIDataSetTableAdapters.USP_GetTotal_NhanVienTableAdapter();
            this.SHOP_GIAC_UIDataSet1 = new Laundry_shop_manager.SHOP_GIAC_UIDataSet1();
            this.USP_GetListDanhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_GetListDanhMucTableAdapter = new Laundry_shop_manager.SHOP_GIAC_UIDataSet1TableAdapters.USP_GetListDanhMucTableAdapter();
            this.SHOP_GIAC_UIDataSet3 = new Laundry_shop_manager.SHOP_GIAC_UIDataSet3();
            this.DANHMUCHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DANHMUCHANGTableAdapter = new Laundry_shop_manager.SHOP_GIAC_UIDataSet3TableAdapters.DANHMUCHANGTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HANGHOATableAdapter = new Laundry_shop_manager.SHOP_GIAC_UIDataSet4TableAdapters.HANGHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHOP_GIAC_UIDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetTotal_NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHOP_GIAC_UIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHOP_GIAC_UIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListDanhMucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHOP_GIAC_UIDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DANHMUCHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HANGHOABindingSource
            // 
            this.HANGHOABindingSource.DataMember = "HANGHOA";
            this.HANGHOABindingSource.DataSource = this.SHOP_GIAC_UIDataSet4;
            // 
            // SHOP_GIAC_UIDataSet4
            // 
            this.SHOP_GIAC_UIDataSet4.DataSetName = "SHOP_GIAC_UIDataSet4";
            this.SHOP_GIAC_UIDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetTotal_NhanVienBindingSource
            // 
            this.USP_GetTotal_NhanVienBindingSource.DataMember = "USP_GetTotal_NhanVien";
            this.USP_GetTotal_NhanVienBindingSource.DataSource = this.SHOP_GIAC_UIDataSet;
            // 
            // SHOP_GIAC_UIDataSet
            // 
            this.SHOP_GIAC_UIDataSet.DataSetName = "SHOP_GIAC_UIDataSet";
            this.SHOP_GIAC_UIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetTotal_NhanVienTableAdapter
            // 
            this.USP_GetTotal_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // SHOP_GIAC_UIDataSet1
            // 
            this.SHOP_GIAC_UIDataSet1.DataSetName = "SHOP_GIAC_UIDataSet1";
            this.SHOP_GIAC_UIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetListDanhMucBindingSource
            // 
            this.USP_GetListDanhMucBindingSource.DataMember = "USP_GetListDanhMuc";
            this.USP_GetListDanhMucBindingSource.DataSource = this.SHOP_GIAC_UIDataSet1;
            // 
            // USP_GetListDanhMucTableAdapter
            // 
            this.USP_GetListDanhMucTableAdapter.ClearBeforeFill = true;
            // 
            // SHOP_GIAC_UIDataSet3
            // 
            this.SHOP_GIAC_UIDataSet3.DataSetName = "SHOP_GIAC_UIDataSet3";
            this.SHOP_GIAC_UIDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DANHMUCHANGBindingSource
            // 
            this.DANHMUCHANGBindingSource.DataMember = "DANHMUCHANG";
            this.DANHMUCHANGBindingSource.DataSource = this.SHOP_GIAC_UIDataSet3;
            // 
            // DANHMUCHANGTableAdapter
            // 
            this.DANHMUCHANGTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HANGHOABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Laundry_shop_manager.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1574, 667);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // HANGHOATableAdapter
            // 
            this.HANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // fThongkeUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThongkeUsercontrol";
            this.Size = new System.Drawing.Size(1580, 673);
            ((System.ComponentModel.ISupportInitialize)(this.HANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHOP_GIAC_UIDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetTotal_NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHOP_GIAC_UIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHOP_GIAC_UIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListDanhMucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHOP_GIAC_UIDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DANHMUCHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource USP_GetTotal_NhanVienBindingSource;
        private SHOP_GIAC_UIDataSet SHOP_GIAC_UIDataSet;
        private SHOP_GIAC_UIDataSetTableAdapters.USP_GetTotal_NhanVienTableAdapter USP_GetTotal_NhanVienTableAdapter;
        private System.Windows.Forms.BindingSource USP_GetListDanhMucBindingSource;
        private SHOP_GIAC_UIDataSet1 SHOP_GIAC_UIDataSet1;
        private SHOP_GIAC_UIDataSet1TableAdapters.USP_GetListDanhMucTableAdapter USP_GetListDanhMucTableAdapter;
        private SHOP_GIAC_UIDataSet3 SHOP_GIAC_UIDataSet3;
        private System.Windows.Forms.BindingSource DANHMUCHANGBindingSource;
        private SHOP_GIAC_UIDataSet3TableAdapters.DANHMUCHANGTableAdapter DANHMUCHANGTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HANGHOABindingSource;
        private SHOP_GIAC_UIDataSet4 SHOP_GIAC_UIDataSet4;
        private SHOP_GIAC_UIDataSet4TableAdapters.HANGHOATableAdapter HANGHOATableAdapter;
    }
}
