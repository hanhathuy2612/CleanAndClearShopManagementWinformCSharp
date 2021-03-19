namespace Laundry_shop_manager
{
    partial class fNhanhangUsercontrol
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
            this.pnDanhsachnhap = new System.Windows.Forms.Panel();
            this.lsvHangHoa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbToongtien = new System.Windows.Forms.Label();
            this.lbExpress = new System.Windows.Forms.Label();
            this.lbChietkhau = new System.Windows.Forms.Label();
            this.lbThanhtien = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.txtExpress = new System.Windows.Forms.TextBox();
            this.txbThanhTien = new System.Windows.Forms.TextBox();
            this.ibtLuuNhanHang = new FontAwesome.Sharp.IconButton();
            this.itbHuy = new FontAwesome.Sharp.IconButton();
            this.lbKhachhang = new System.Windows.Forms.Label();
            this.lbSodienthoai = new System.Windows.Forms.Label();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.txbTenKhach = new System.Windows.Forms.TextBox();
            this.txbSdtKhach = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.ibtExpress = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelButtonNhap = new System.Windows.Forms.FlowLayoutPanel();
            this.icbtnBack = new FontAwesome.Sharp.IconButton();
            this.txbIdNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLishKhachHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearchTenKhach = new System.Windows.Forms.TextBox();
            this.pnDanhsachnhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLishKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDanhsachnhap
            // 
            this.pnDanhsachnhap.Controls.Add(this.lsvHangHoa);
            this.pnDanhsachnhap.Location = new System.Drawing.Point(4, 4);
            this.pnDanhsachnhap.Margin = new System.Windows.Forms.Padding(4);
            this.pnDanhsachnhap.Name = "pnDanhsachnhap";
            this.pnDanhsachnhap.Size = new System.Drawing.Size(403, 380);
            this.pnDanhsachnhap.TabIndex = 0;
            // 
            // lsvHangHoa
            // 
            this.lsvHangHoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvHangHoa.FullRowSelect = true;
            this.lsvHangHoa.HideSelection = false;
            this.lsvHangHoa.Location = new System.Drawing.Point(5, 5);
            this.lsvHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.lsvHangHoa.Name = "lsvHangHoa";
            this.lsvHangHoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lsvHangHoa.Size = new System.Drawing.Size(392, 374);
            this.lsvHangHoa.TabIndex = 0;
            this.lsvHangHoa.UseCompatibleStateImageBehavior = false;
            this.lsvHangHoa.View = System.Windows.Forms.View.Details;
            this.lsvHangHoa.SelectedIndexChanged += new System.EventHandler(this.lsvHangHoa_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng hóa";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbToongtien
            // 
            this.lbToongtien.AutoSize = true;
            this.lbToongtien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbToongtien.Location = new System.Drawing.Point(4, 395);
            this.lbToongtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbToongtien.Name = "lbToongtien";
            this.lbToongtien.Size = new System.Drawing.Size(93, 22);
            this.lbToongtien.TabIndex = 2;
            this.lbToongtien.Text = "Tổng tiền:";
            // 
            // lbExpress
            // 
            this.lbExpress.AutoSize = true;
            this.lbExpress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbExpress.Location = new System.Drawing.Point(4, 423);
            this.lbExpress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExpress.Name = "lbExpress";
            this.lbExpress.Size = new System.Drawing.Size(80, 22);
            this.lbExpress.TabIndex = 3;
            this.lbExpress.Text = "Express:";
            // 
            // lbChietkhau
            // 
            this.lbChietkhau.AutoSize = true;
            this.lbChietkhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbChietkhau.Location = new System.Drawing.Point(1, 459);
            this.lbChietkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChietkhau.Name = "lbChietkhau";
            this.lbChietkhau.Size = new System.Drawing.Size(105, 22);
            this.lbChietkhau.TabIndex = 4;
            this.lbChietkhau.Text = "Chiết khấu:";
            // 
            // lbThanhtien
            // 
            this.lbThanhtien.AutoSize = true;
            this.lbThanhtien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbThanhtien.Location = new System.Drawing.Point(4, 491);
            this.lbThanhtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThanhtien.Name = "lbThanhtien";
            this.lbThanhtien.Size = new System.Drawing.Size(103, 22);
            this.lbThanhtien.TabIndex = 5;
            this.lbThanhtien.Text = "Thành tiền:";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(128, 391);
            this.txbTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Size = new System.Drawing.Size(277, 22);
            this.txbTongTien.TabIndex = 6;
            this.txbTongTien.Text = "0";
            // 
            // txtExpress
            // 
            this.txtExpress.Location = new System.Drawing.Point(128, 423);
            this.txtExpress.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpress.Name = "txtExpress";
            this.txtExpress.Size = new System.Drawing.Size(277, 22);
            this.txtExpress.TabIndex = 7;
            // 
            // txbThanhTien
            // 
            this.txbThanhTien.Location = new System.Drawing.Point(128, 487);
            this.txbThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txbThanhTien.Name = "txbThanhTien";
            this.txbThanhTien.Size = new System.Drawing.Size(277, 22);
            this.txbThanhTien.TabIndex = 9;
            this.txbThanhTien.Text = "0";
            // 
            // ibtLuuNhanHang
            // 
            this.ibtLuuNhanHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtLuuNhanHang.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtLuuNhanHang.IconColor = System.Drawing.Color.Black;
            this.ibtLuuNhanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtLuuNhanHang.IconSize = 40;
            this.ibtLuuNhanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtLuuNhanHang.Location = new System.Drawing.Point(8, 534);
            this.ibtLuuNhanHang.Margin = new System.Windows.Forms.Padding(4);
            this.ibtLuuNhanHang.Name = "ibtLuuNhanHang";
            this.ibtLuuNhanHang.Size = new System.Drawing.Size(176, 54);
            this.ibtLuuNhanHang.TabIndex = 10;
            this.ibtLuuNhanHang.Text = "Lưu";
            this.ibtLuuNhanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtLuuNhanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtLuuNhanHang.UseVisualStyleBackColor = true;
            this.ibtLuuNhanHang.Click += new System.EventHandler(this.ibtLuuNhanHang_Click);
            // 
            // itbHuy
            // 
            this.itbHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.itbHuy.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.itbHuy.IconColor = System.Drawing.Color.Black;
            this.itbHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itbHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itbHuy.Location = new System.Drawing.Point(128, 596);
            this.itbHuy.Margin = new System.Windows.Forms.Padding(4);
            this.itbHuy.Name = "itbHuy";
            this.itbHuy.Size = new System.Drawing.Size(176, 54);
            this.itbHuy.TabIndex = 13;
            this.itbHuy.Text = "Hủy";
            this.itbHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itbHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itbHuy.UseVisualStyleBackColor = true;
            this.itbHuy.Click += new System.EventHandler(this.itbHuy_Click);
            // 
            // lbKhachhang
            // 
            this.lbKhachhang.AutoSize = true;
            this.lbKhachhang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbKhachhang.Location = new System.Drawing.Point(24, 81);
            this.lbKhachhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhachhang.Name = "lbKhachhang";
            this.lbKhachhang.Size = new System.Drawing.Size(102, 22);
            this.lbKhachhang.TabIndex = 14;
            this.lbKhachhang.Text = "Tên khách:";
            // 
            // lbSodienthoai
            // 
            this.lbSodienthoai.AutoSize = true;
            this.lbSodienthoai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbSodienthoai.Location = new System.Drawing.Point(24, 180);
            this.lbSodienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSodienthoai.Name = "lbSodienthoai";
            this.lbSodienthoai.Size = new System.Drawing.Size(121, 22);
            this.lbSodienthoai.TabIndex = 15;
            this.lbSodienthoai.Text = "Số điện thoại:";
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbDiachi.Location = new System.Drawing.Point(24, 131);
            this.lbDiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(73, 22);
            this.lbDiachi.TabIndex = 16;
            this.lbDiachi.Text = "Địa chỉ:";
            // 
            // txbTenKhach
            // 
            this.txbTenKhach.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbTenKhach.Location = new System.Drawing.Point(169, 81);
            this.txbTenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenKhach.Name = "txbTenKhach";
            this.txbTenKhach.Size = new System.Drawing.Size(198, 26);
            this.txbTenKhach.TabIndex = 17;
            // 
            // txbSdtKhach
            // 
            this.txbSdtKhach.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbSdtKhach.Location = new System.Drawing.Point(169, 180);
            this.txbSdtKhach.Margin = new System.Windows.Forms.Padding(4);
            this.txbSdtKhach.Name = "txbSdtKhach";
            this.txbSdtKhach.Size = new System.Drawing.Size(198, 26);
            this.txbSdtKhach.TabIndex = 18;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbDiaChi.Location = new System.Drawing.Point(169, 131);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(198, 26);
            this.txbDiaChi.TabIndex = 19;
            // 
            // ibtExpress
            // 
            this.ibtExpress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtExpress.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.ibtExpress.IconColor = System.Drawing.Color.Black;
            this.ibtExpress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtExpress.IconSize = 40;
            this.ibtExpress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtExpress.Location = new System.Drawing.Point(208, 534);
            this.ibtExpress.Margin = new System.Windows.Forms.Padding(4);
            this.ibtExpress.Name = "ibtExpress";
            this.ibtExpress.Size = new System.Drawing.Size(176, 54);
            this.ibtExpress.TabIndex = 11;
            this.ibtExpress.Text = "Express";
            this.ibtExpress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtExpress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtExpress.UseVisualStyleBackColor = true;
            this.ibtExpress.Click += new System.EventHandler(this.ibtExpress_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5%",
            "10%",
            "15%",
            "20%",
            "35%",
            "40%",
            "45%",
            "50%"});
            this.comboBox1.Location = new System.Drawing.Point(128, 457);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanelButtonNhap
            // 
            this.flowLayoutPanelButtonNhap.BackColor = System.Drawing.Color.OldLace;
            this.flowLayoutPanelButtonNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelButtonNhap.Location = new System.Drawing.Point(416, 5);
            this.flowLayoutPanelButtonNhap.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelButtonNhap.Name = "flowLayoutPanelButtonNhap";
            this.flowLayoutPanelButtonNhap.Size = new System.Drawing.Size(1159, 379);
            this.flowLayoutPanelButtonNhap.TabIndex = 21;
            // 
            // icbtnBack
            // 
            this.icbtnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.icbtnBack.IconColor = System.Drawing.Color.Black;
            this.icbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnBack.IconSize = 30;
            this.icbtnBack.Location = new System.Drawing.Point(1449, 391);
            this.icbtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.icbtnBack.Name = "icbtnBack";
            this.icbtnBack.Size = new System.Drawing.Size(126, 39);
            this.icbtnBack.TabIndex = 22;
            this.icbtnBack.UseVisualStyleBackColor = true;
            this.icbtnBack.Click += new System.EventHandler(this.icbtnBack_Click);
            // 
            // txbIdNhanVien
            // 
            this.txbIdNhanVien.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbIdNhanVien.Location = new System.Drawing.Point(169, 34);
            this.txbIdNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txbIdNhanVien.Name = "txbIdNhanVien";
            this.txbIdNhanVien.ReadOnly = true;
            this.txbIdNhanVien.Size = new System.Drawing.Size(85, 26);
            this.txbIdNhanVien.TabIndex = 24;
            this.txbIdNhanVien.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbSearchTenKhach);
            this.groupBox1.Controls.Add(this.dgvLishKhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbIdNhanVien);
            this.groupBox1.Controls.Add(this.lbKhachhang);
            this.groupBox1.Controls.Add(this.lbSodienthoai);
            this.groupBox1.Controls.Add(this.lbDiachi);
            this.groupBox1.Controls.Add(this.txbTenKhach);
            this.groupBox1.Controls.Add(this.txbSdtKhach);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Location = new System.Drawing.Point(416, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 227);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // dgvLishKhachHang
            // 
            this.dgvLishKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLishKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLishKhachHang.Location = new System.Drawing.Point(404, 54);
            this.dgvLishKhachHang.Name = "dgvLishKhachHang";
            this.dgvLishKhachHang.RowHeadersWidth = 51;
            this.dgvLishKhachHang.RowTemplate.Height = 24;
            this.dgvLishKhachHang.Size = new System.Drawing.Size(735, 153);
            this.dgvLishKhachHang.TabIndex = 25;
            this.dgvLishKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLishKhachHang_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(410, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tìm khách";
            // 
            // txbSearchTenKhach
            // 
            this.txbSearchTenKhach.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbSearchTenKhach.Location = new System.Drawing.Point(516, 17);
            this.txbSearchTenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchTenKhach.Name = "txbSearchTenKhach";
            this.txbSearchTenKhach.Size = new System.Drawing.Size(165, 26);
            this.txbSearchTenKhach.TabIndex = 27;
            this.txbSearchTenKhach.TextChanged += new System.EventHandler(this.txbSearchTenKhach_TextChanged);
            // 
            // fNhanhangUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.icbtnBack);
            this.Controls.Add(this.flowLayoutPanelButtonNhap);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.itbHuy);
            this.Controls.Add(this.ibtExpress);
            this.Controls.Add(this.ibtLuuNhanHang);
            this.Controls.Add(this.txbThanhTien);
            this.Controls.Add(this.txtExpress);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.lbThanhtien);
            this.Controls.Add(this.lbChietkhau);
            this.Controls.Add(this.lbExpress);
            this.Controls.Add(this.lbToongtien);
            this.Controls.Add(this.pnDanhsachnhap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fNhanhangUsercontrol";
            this.Size = new System.Drawing.Size(1580, 673);
            this.Load += new System.EventHandler(this.fNhanhangUsercontrol_Load);
            this.pnDanhsachnhap.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLishKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDanhsachnhap;
        private System.Windows.Forms.Label lbToongtien;
        private System.Windows.Forms.Label lbExpress;
        private System.Windows.Forms.Label lbChietkhau;
        private System.Windows.Forms.Label lbThanhtien;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.TextBox txtExpress;
        private System.Windows.Forms.TextBox txbThanhTien;
        private FontAwesome.Sharp.IconButton ibtLuuNhanHang;
        private FontAwesome.Sharp.IconButton itbHuy;
        private System.Windows.Forms.Label lbKhachhang;
        private System.Windows.Forms.Label lbSodienthoai;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.TextBox txbTenKhach;
        private System.Windows.Forms.TextBox txbSdtKhach;
        private System.Windows.Forms.TextBox txbDiaChi;
        private FontAwesome.Sharp.IconButton ibtExpress;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtonNhap;
        private FontAwesome.Sharp.IconButton icbtnBack;
        private System.Windows.Forms.ListView lsvHangHoa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbIdNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLishKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSearchTenKhach;
    }
}
