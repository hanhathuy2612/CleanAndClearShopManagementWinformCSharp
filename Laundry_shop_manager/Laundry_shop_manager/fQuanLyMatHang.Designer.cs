
namespace Laundry_shop_manager
{
    partial class fQuanLyMatHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListHang = new System.Windows.Forms.DataGridView();
            this.grThongTinMatHang = new System.Windows.Forms.GroupBox();
            this.icbtDelete = new FontAwesome.Sharp.IconButton();
            this.cbxDanhMuc = new System.Windows.Forms.ComboBox();
            this.uSPGetListDanhMucBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sHOP_GIAC_UIDataSet2 = new Laundry_shop_manager.SHOP_GIAC_UIDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.icbtRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtUpdate = new FontAwesome.Sharp.IconButton();
            this.ibtAdd = new FontAwesome.Sharp.IconButton();
            this.txbIdHang = new System.Windows.Forms.TextBox();
            this.txtMaMatHang = new System.Windows.Forms.Label();
            this.txbGiaTien = new System.Windows.Forms.TextBox();
            this.txbTenHang = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.Label();
            this.gbTimMatHang = new System.Windows.Forms.GroupBox();
            this.ibtTim = new FontAwesome.Sharp.IconButton();
            this.txbTimTheoTen = new System.Windows.Forms.TextBox();
            this.txtTimTheoTen = new System.Windows.Forms.Label();
            this.sHOP_GIAC_UIDataSet = new Laundry_shop_manager.SHOP_GIAC_UIDataSet();
            this.sHOPGIACUIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sHOP_GIAC_UIDataSet1 = new Laundry_shop_manager.SHOP_GIAC_UIDataSet1();
            this.uSPGetListDanhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetListDanhMucTableAdapter = new Laundry_shop_manager.SHOP_GIAC_UIDataSet1TableAdapters.USP_GetListDanhMucTableAdapter();
            this.uSP_GetListDanhMucTableAdapter1 = new Laundry_shop_manager.SHOP_GIAC_UIDataSet2TableAdapters.USP_GetListDanhMucTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHang)).BeginInit();
            this.grThongTinMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListDanhMucBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP_GIAC_UIDataSet2)).BeginInit();
            this.gbTimMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP_GIAC_UIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPGIACUIDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP_GIAC_UIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListDanhMucBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListHang);
            this.panel1.Location = new System.Drawing.Point(5, 245);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 425);
            this.panel1.TabIndex = 0;
            // 
            // dgvListHang
            // 
            this.dgvListHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHang.Location = new System.Drawing.Point(5, 4);
            this.dgvListHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListHang.Name = "dgvListHang";
            this.dgvListHang.RowHeadersWidth = 51;
            this.dgvListHang.Size = new System.Drawing.Size(1561, 418);
            this.dgvListHang.TabIndex = 0;
            this.dgvListHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListHang_CellClick);
            // 
            // grThongTinMatHang
            // 
            this.grThongTinMatHang.Controls.Add(this.icbtDelete);
            this.grThongTinMatHang.Controls.Add(this.cbxDanhMuc);
            this.grThongTinMatHang.Controls.Add(this.label1);
            this.grThongTinMatHang.Controls.Add(this.icbtRefresh);
            this.grThongTinMatHang.Controls.Add(this.ibtUpdate);
            this.grThongTinMatHang.Controls.Add(this.ibtAdd);
            this.grThongTinMatHang.Controls.Add(this.txbIdHang);
            this.grThongTinMatHang.Controls.Add(this.txtMaMatHang);
            this.grThongTinMatHang.Controls.Add(this.txbGiaTien);
            this.grThongTinMatHang.Controls.Add(this.txbTenHang);
            this.grThongTinMatHang.Controls.Add(this.txtTenMatHang);
            this.grThongTinMatHang.Controls.Add(this.txtGiaTien);
            this.grThongTinMatHang.Location = new System.Drawing.Point(5, 4);
            this.grThongTinMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.grThongTinMatHang.Name = "grThongTinMatHang";
            this.grThongTinMatHang.Padding = new System.Windows.Forms.Padding(4);
            this.grThongTinMatHang.Size = new System.Drawing.Size(795, 234);
            this.grThongTinMatHang.TabIndex = 5;
            this.grThongTinMatHang.TabStop = false;
            this.grThongTinMatHang.Text = "Thông tin mặt hàng";
            this.grThongTinMatHang.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // icbtDelete
            // 
            this.icbtDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icbtDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.icbtDelete.IconColor = System.Drawing.Color.Black;
            this.icbtDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtDelete.IconSize = 30;
            this.icbtDelete.Location = new System.Drawing.Point(591, 128);
            this.icbtDelete.Margin = new System.Windows.Forms.Padding(4);
            this.icbtDelete.Name = "icbtDelete";
            this.icbtDelete.Size = new System.Drawing.Size(140, 42);
            this.icbtDelete.TabIndex = 14;
            this.icbtDelete.Text = "Xóa";
            this.icbtDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtDelete.UseVisualStyleBackColor = true;
            this.icbtDelete.Click += new System.EventHandler(this.icbtDelete_Click);
            // 
            // cbxDanhMuc
            // 
            this.cbxDanhMuc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uSPGetListDanhMucBindingSource1, "TenDM", true));
            this.cbxDanhMuc.DataSource = this.uSPGetListDanhMucBindingSource1;
            this.cbxDanhMuc.DisplayMember = "TenDM";
            this.cbxDanhMuc.FormattingEnabled = true;
            this.cbxDanhMuc.Location = new System.Drawing.Point(149, 169);
            this.cbxDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDanhMuc.Name = "cbxDanhMuc";
            this.cbxDanhMuc.Size = new System.Drawing.Size(372, 24);
            this.cbxDanhMuc.TabIndex = 13;
            this.cbxDanhMuc.ValueMember = "ID_DM";
            // 
            // uSPGetListDanhMucBindingSource1
            // 
            this.uSPGetListDanhMucBindingSource1.DataMember = "USP_GetListDanhMuc";
            this.uSPGetListDanhMucBindingSource1.DataSource = this.sHOP_GIAC_UIDataSet2;
            // 
            // sHOP_GIAC_UIDataSet2
            // 
            this.sHOP_GIAC_UIDataSet2.DataSetName = "SHOP_GIAC_UIDataSet2";
            this.sHOP_GIAC_UIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh mục";
            // 
            // icbtRefresh
            // 
            this.icbtRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtRefresh.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.icbtRefresh.IconColor = System.Drawing.Color.Black;
            this.icbtRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtRefresh.IconSize = 30;
            this.icbtRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtRefresh.Location = new System.Drawing.Point(591, 181);
            this.icbtRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icbtRefresh.Name = "icbtRefresh";
            this.icbtRefresh.Size = new System.Drawing.Size(140, 47);
            this.icbtRefresh.TabIndex = 11;
            this.icbtRefresh.Text = "Làm mới";
            this.icbtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtRefresh.UseVisualStyleBackColor = true;
            this.icbtRefresh.Click += new System.EventHandler(this.icbtRefresh_Click);
            // 
            // ibtUpdate
            // 
            this.ibtUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtUpdate.IconColor = System.Drawing.Color.Black;
            this.ibtUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtUpdate.IconSize = 30;
            this.ibtUpdate.Location = new System.Drawing.Point(591, 73);
            this.ibtUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.ibtUpdate.Name = "ibtUpdate";
            this.ibtUpdate.Size = new System.Drawing.Size(140, 42);
            this.ibtUpdate.TabIndex = 9;
            this.ibtUpdate.Text = "Sửa";
            this.ibtUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtUpdate.UseVisualStyleBackColor = true;
            this.ibtUpdate.Click += new System.EventHandler(this.ibtUpdate_Click);
            // 
            // ibtAdd
            // 
            this.ibtAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtAdd.IconColor = System.Drawing.Color.Black;
            this.ibtAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtAdd.IconSize = 30;
            this.ibtAdd.Location = new System.Drawing.Point(591, 23);
            this.ibtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ibtAdd.Name = "ibtAdd";
            this.ibtAdd.Size = new System.Drawing.Size(140, 42);
            this.ibtAdd.TabIndex = 8;
            this.ibtAdd.Text = "Thêm";
            this.ibtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtAdd.UseVisualStyleBackColor = true;
            this.ibtAdd.Click += new System.EventHandler(this.ibtAdd_Click);
            // 
            // txbIdHang
            // 
            this.txbIdHang.Location = new System.Drawing.Point(149, 34);
            this.txbIdHang.Margin = new System.Windows.Forms.Padding(4);
            this.txbIdHang.Name = "txbIdHang";
            this.txbIdHang.ReadOnly = true;
            this.txbIdHang.Size = new System.Drawing.Size(91, 22);
            this.txbIdHang.TabIndex = 7;
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.AutoSize = true;
            this.txtMaMatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMatHang.Location = new System.Drawing.Point(8, 33);
            this.txtMaMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(31, 23);
            this.txtMaMatHang.TabIndex = 6;
            this.txtMaMatHang.Text = "ID";
            // 
            // txbGiaTien
            // 
            this.txbGiaTien.Location = new System.Drawing.Point(149, 129);
            this.txbGiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txbGiaTien.Name = "txbGiaTien";
            this.txbGiaTien.Size = new System.Drawing.Size(372, 22);
            this.txbGiaTien.TabIndex = 5;
            // 
            // txbTenHang
            // 
            this.txbTenHang.Location = new System.Drawing.Point(149, 82);
            this.txbTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenHang.Name = "txbTenHang";
            this.txbTenHang.Size = new System.Drawing.Size(372, 22);
            this.txbTenHang.TabIndex = 4;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.AutoSize = true;
            this.txtTenMatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMatHang.Location = new System.Drawing.Point(8, 81);
            this.txtTenMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(124, 23);
            this.txtTenMatHang.TabIndex = 1;
            this.txtTenMatHang.Text = "Tên mặt hàng";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.AutoSize = true;
            this.txtGiaTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaTien.Location = new System.Drawing.Point(8, 128);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(78, 23);
            this.txtGiaTien.TabIndex = 2;
            this.txtGiaTien.Text = "Giá tiền";
            // 
            // gbTimMatHang
            // 
            this.gbTimMatHang.Controls.Add(this.ibtTim);
            this.gbTimMatHang.Controls.Add(this.txbTimTheoTen);
            this.gbTimMatHang.Controls.Add(this.txtTimTheoTen);
            this.gbTimMatHang.Location = new System.Drawing.Point(843, 6);
            this.gbTimMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.gbTimMatHang.Name = "gbTimMatHang";
            this.gbTimMatHang.Padding = new System.Windows.Forms.Padding(4);
            this.gbTimMatHang.Size = new System.Drawing.Size(528, 151);
            this.gbTimMatHang.TabIndex = 6;
            this.gbTimMatHang.TabStop = false;
            this.gbTimMatHang.Text = "Tìm mặt hàng";
            // 
            // ibtTim
            // 
            this.ibtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtTim.IconColor = System.Drawing.Color.Black;
            this.ibtTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtTim.IconSize = 30;
            this.ibtTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtTim.Location = new System.Drawing.Point(13, 69);
            this.ibtTim.Margin = new System.Windows.Forms.Padding(4);
            this.ibtTim.Name = "ibtTim";
            this.ibtTim.Size = new System.Drawing.Size(500, 42);
            this.ibtTim.TabIndex = 8;
            this.ibtTim.Text = "Tìm";
            this.ibtTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtTim.UseVisualStyleBackColor = true;
            this.ibtTim.Click += new System.EventHandler(this.ibtTim_Click);
            // 
            // txbTimTheoTen
            // 
            this.txbTimTheoTen.Location = new System.Drawing.Point(140, 30);
            this.txbTimTheoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbTimTheoTen.Name = "txbTimTheoTen";
            this.txbTimTheoTen.Size = new System.Drawing.Size(372, 22);
            this.txbTimTheoTen.TabIndex = 4;
            // 
            // txtTimTheoTen
            // 
            this.txtTimTheoTen.AutoSize = true;
            this.txtTimTheoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimTheoTen.Location = new System.Drawing.Point(8, 31);
            this.txtTimTheoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTimTheoTen.Name = "txtTimTheoTen";
            this.txtTimTheoTen.Size = new System.Drawing.Size(117, 23);
            this.txtTimTheoTen.TabIndex = 1;
            this.txtTimTheoTen.Text = "Tìm theo tên";
            // 
            // sHOP_GIAC_UIDataSet
            // 
            this.sHOP_GIAC_UIDataSet.DataSetName = "SHOP_GIAC_UIDataSet";
            this.sHOP_GIAC_UIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sHOPGIACUIDataSetBindingSource
            // 
            this.sHOPGIACUIDataSetBindingSource.DataSource = this.sHOP_GIAC_UIDataSet;
            this.sHOPGIACUIDataSetBindingSource.Position = 0;
            // 
            // sHOP_GIAC_UIDataSet1
            // 
            this.sHOP_GIAC_UIDataSet1.DataSetName = "SHOP_GIAC_UIDataSet1";
            this.sHOP_GIAC_UIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPGetListDanhMucBindingSource
            // 
            this.uSPGetListDanhMucBindingSource.DataMember = "USP_GetListDanhMuc";
            this.uSPGetListDanhMucBindingSource.DataSource = this.sHOP_GIAC_UIDataSet1;
            // 
            // uSP_GetListDanhMucTableAdapter
            // 
            this.uSP_GetListDanhMucTableAdapter.ClearBeforeFill = true;
            // 
            // uSP_GetListDanhMucTableAdapter1
            // 
            this.uSP_GetListDanhMucTableAdapter1.ClearBeforeFill = true;
            // 
            // fQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gbTimMatHang);
            this.Controls.Add(this.grThongTinMatHang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLyMatHang";
            this.Size = new System.Drawing.Size(1577, 671);
            this.Load += new System.EventHandler(this.fQuanLyMatHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHang)).EndInit();
            this.grThongTinMatHang.ResumeLayout(false);
            this.grThongTinMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListDanhMucBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP_GIAC_UIDataSet2)).EndInit();
            this.gbTimMatHang.ResumeLayout(false);
            this.gbTimMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP_GIAC_UIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPGIACUIDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOP_GIAC_UIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListDanhMucBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grThongTinMatHang;
        private System.Windows.Forms.TextBox txbGiaTien;
        private System.Windows.Forms.TextBox txbTenHang;
        private System.Windows.Forms.Label txtTenMatHang;
        private System.Windows.Forms.Label txtGiaTien;
        private System.Windows.Forms.DataGridView dgvListHang;
        private System.Windows.Forms.TextBox txbIdHang;
        private System.Windows.Forms.Label txtMaMatHang;
        private System.Windows.Forms.GroupBox gbTimMatHang;
        private System.Windows.Forms.TextBox txbTimTheoTen;
        private System.Windows.Forms.Label txtTimTheoTen;
        private FontAwesome.Sharp.IconButton ibtAdd;
        private FontAwesome.Sharp.IconButton ibtUpdate;
        private FontAwesome.Sharp.IconButton icbtRefresh;
        private FontAwesome.Sharp.IconButton ibtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDanhMuc;
        private System.Windows.Forms.BindingSource uSPGetListDanhMucBindingSource;
        private SHOP_GIAC_UIDataSet1 sHOP_GIAC_UIDataSet1;
        private SHOP_GIAC_UIDataSet sHOP_GIAC_UIDataSet;
        private System.Windows.Forms.BindingSource sHOPGIACUIDataSetBindingSource;
        private SHOP_GIAC_UIDataSet1TableAdapters.USP_GetListDanhMucTableAdapter uSP_GetListDanhMucTableAdapter;
        private System.Windows.Forms.BindingSource uSPGetListDanhMucBindingSource1;
        private SHOP_GIAC_UIDataSet2 sHOP_GIAC_UIDataSet2;
        private SHOP_GIAC_UIDataSet2TableAdapters.USP_GetListDanhMucTableAdapter uSP_GetListDanhMucTableAdapter1;
        private FontAwesome.Sharp.IconButton icbtDelete;
    }
}
