namespace Laundry_shop_manager
{
    partial class fQuanLyNhanVien
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
            this.pnDataQuanLyTaiKhoan = new System.Windows.Forms.Panel();
            this.dgvListNhanVien = new System.Windows.Forms.DataGridView();
            this.lbThemTaiKhoan = new System.Windows.Forms.Label();
            this.txbHoVaTen = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.lbTImTheoTenNhanVien = new System.Windows.Forms.Label();
            this.txbSearchName = new System.Windows.Forms.TextBox();
            this.lbHoVaTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.lbTenTaiKhoanThemTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhauThemTaiKhoan = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPathAnhDD = new System.Windows.Forms.Label();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIdNhanVien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbIdAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearchSDT = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ibtTimTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.icbtRefresh = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icbtEdit = new FontAwesome.Sharp.IconButton();
            this.icbtAdd = new FontAwesome.Sharp.IconButton();
            this.pnDataQuanLyTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDataQuanLyTaiKhoan
            // 
            this.pnDataQuanLyTaiKhoan.Controls.Add(this.dgvListNhanVien);
            this.pnDataQuanLyTaiKhoan.Location = new System.Drawing.Point(7, 311);
            this.pnDataQuanLyTaiKhoan.Name = "pnDataQuanLyTaiKhoan";
            this.pnDataQuanLyTaiKhoan.Size = new System.Drawing.Size(1169, 233);
            this.pnDataQuanLyTaiKhoan.TabIndex = 0;
            // 
            // dgvListNhanVien
            // 
            this.dgvListNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListNhanVien.Location = new System.Drawing.Point(3, 3);
            this.dgvListNhanVien.Name = "dgvListNhanVien";
            this.dgvListNhanVien.RowHeadersWidth = 51;
            this.dgvListNhanVien.Size = new System.Drawing.Size(1163, 227);
            this.dgvListNhanVien.TabIndex = 0;
            this.dgvListNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListNhanVien_CellClick);
            this.dgvListNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbThemTaiKhoan
            // 
            this.lbThemTaiKhoan.AutoSize = true;
            this.lbThemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThemTaiKhoan.Location = new System.Drawing.Point(478, 15);
            this.lbThemTaiKhoan.Name = "lbThemTaiKhoan";
            this.lbThemTaiKhoan.Size = new System.Drawing.Size(199, 26);
            this.lbThemTaiKhoan.TabIndex = 1;
            this.lbThemTaiKhoan.Text = "Quản lý nhân viên";
            this.lbThemTaiKhoan.Click += new System.EventHandler(this.lbThemTaiKhoan_Click);
            // 
            // txbHoVaTen
            // 
            this.txbHoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbHoVaTen.Location = new System.Drawing.Point(124, 50);
            this.txbHoVaTen.Name = "txbHoVaTen";
            this.txbHoVaTen.Size = new System.Drawing.Size(145, 26);
            this.txbHoVaTen.TabIndex = 4;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiaChi.Location = new System.Drawing.Point(124, 83);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(223, 26);
            this.txbDiaChi.TabIndex = 5;
            // 
            // lbTImTheoTenNhanVien
            // 
            this.lbTImTheoTenNhanVien.AutoSize = true;
            this.lbTImTheoTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTImTheoTenNhanVien.Location = new System.Drawing.Point(14, 37);
            this.lbTImTheoTenNhanVien.Name = "lbTImTheoTenNhanVien";
            this.lbTImTheoTenNhanVien.Size = new System.Drawing.Size(93, 19);
            this.lbTImTheoTenNhanVien.TabIndex = 6;
            this.lbTImTheoTenNhanVien.Text = "Tìm theo tên";
            // 
            // txbSearchName
            // 
            this.txbSearchName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchName.Location = new System.Drawing.Point(125, 35);
            this.txbSearchName.Name = "txbSearchName";
            this.txbSearchName.Size = new System.Drawing.Size(144, 26);
            this.txbSearchName.TabIndex = 7;
            // 
            // lbHoVaTen
            // 
            this.lbHoVaTen.AutoSize = true;
            this.lbHoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoVaTen.Location = new System.Drawing.Point(14, 54);
            this.lbHoVaTen.Name = "lbHoVaTen";
            this.lbHoVaTen.Size = new System.Drawing.Size(74, 19);
            this.lbHoVaTen.TabIndex = 8;
            this.lbHoVaTen.Text = "Họ và tên";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(14, 85);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(60, 19);
            this.lbDiaChi.TabIndex = 9;
            this.lbDiaChi.Text = "Địa chỉ ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSDT.Location = new System.Drawing.Point(14, 118);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(95, 19);
            this.lbSDT.TabIndex = 10;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSDT.Location = new System.Drawing.Point(124, 115);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(145, 26);
            this.txbSDT.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ngày sinh";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucVu.Location = new System.Drawing.Point(14, 182);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(65, 19);
            this.lbChucVu.TabIndex = 14;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "admin",
            "ketoan",
            "nhanvien",
            "xuong"});
            this.cbbChucVu.Location = new System.Drawing.Point(124, 179);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(145, 27);
            this.cbbChucVu.TabIndex = 15;
            // 
            // lbTenTaiKhoanThemTaiKhoan
            // 
            this.lbTenTaiKhoanThemTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoanThemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenTaiKhoanThemTaiKhoan.Location = new System.Drawing.Point(14, 58);
            this.lbTenTaiKhoanThemTaiKhoan.Name = "lbTenTaiKhoanThemTaiKhoan";
            this.lbTenTaiKhoanThemTaiKhoan.Size = new System.Drawing.Size(76, 19);
            this.lbTenTaiKhoanThemTaiKhoan.TabIndex = 16;
            this.lbTenTaiKhoanThemTaiKhoan.Text = "Tài khoản";
            // 
            // lbMatKhauThemTaiKhoan
            // 
            this.lbMatKhauThemTaiKhoan.AutoSize = true;
            this.lbMatKhauThemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMatKhauThemTaiKhoan.Location = new System.Drawing.Point(14, 90);
            this.lbMatKhauThemTaiKhoan.Name = "lbMatKhauThemTaiKhoan";
            this.lbMatKhauThemTaiKhoan.Size = new System.Drawing.Size(75, 19);
            this.lbMatKhauThemTaiKhoan.TabIndex = 17;
            this.lbMatKhauThemTaiKhoan.Text = "Mật khẩu";
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbUserName.Location = new System.Drawing.Point(125, 55);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(144, 26);
            this.txbUserName.TabIndex = 18;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassWord.Location = new System.Drawing.Point(125, 88);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '*';
            this.txbPassWord.Size = new System.Drawing.Size(144, 26);
            this.txbPassWord.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.icbtRefresh);
            this.groupBox1.Controls.Add(this.lbPathAnhDD);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtpkNgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbIdNhanVien);
            this.groupBox1.Controls.Add(this.lbHoVaTen);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.icbtEdit);
            this.groupBox1.Controls.Add(this.txbHoVaTen);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.icbtAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbChucVu);
            this.groupBox1.Controls.Add(this.txbSDT);
            this.groupBox1.Controls.Add(this.lbChucVu);
            this.groupBox1.Location = new System.Drawing.Point(3, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 210);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // lbPathAnhDD
            // 
            this.lbPathAnhDD.AutoSize = true;
            this.lbPathAnhDD.Location = new System.Drawing.Point(382, 144);
            this.lbPathAnhDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPathAnhDD.Name = "lbPathAnhDD";
            this.lbPathAnhDD.Size = new System.Drawing.Size(69, 13);
            this.lbPathAnhDD.TabIndex = 29;
            this.lbPathAnhDD.Text = "chưa có hình";
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(124, 150);
            this.dtpkNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(145, 20);
            this.dtpkNgaySinh.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID";
            // 
            // txbIdNhanVien
            // 
            this.txbIdNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIdNhanVien.Location = new System.Drawing.Point(124, 19);
            this.txbIdNhanVien.Name = "txbIdNhanVien";
            this.txbIdNhanVien.ReadOnly = true;
            this.txbIdNhanVien.Size = new System.Drawing.Size(58, 26);
            this.txbIdNhanVien.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbIdAccount);
            this.groupBox2.Controls.Add(this.lbTenTaiKhoanThemTaiKhoan);
            this.groupBox2.Controls.Add(this.txbUserName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbPassWord);
            this.groupBox2.Controls.Add(this.lbMatKhauThemTaiKhoan);
            this.groupBox2.Location = new System.Drawing.Point(527, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 126);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lập tài khoản";
            // 
            // txbIdAccount
            // 
            this.txbIdAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIdAccount.Location = new System.Drawing.Point(125, 22);
            this.txbIdAccount.Name = "txbIdAccount";
            this.txbIdAccount.ReadOnly = true;
            this.txbIdAccount.Size = new System.Drawing.Size(65, 26);
            this.txbIdAccount.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tìm theo SĐT";
            // 
            // txbSearchSDT
            // 
            this.txbSearchSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchSDT.Location = new System.Drawing.Point(123, 68);
            this.txbSearchSDT.Name = "txbSearchSDT";
            this.txbSearchSDT.Size = new System.Drawing.Size(144, 26);
            this.txbSearchSDT.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTImTheoTenNhanVien);
            this.groupBox3.Controls.Add(this.ibtTimTaiKhoan);
            this.groupBox3.Controls.Add(this.txbSearchName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txbSearchSDT);
            this.groupBox3.Location = new System.Drawing.Point(862, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 210);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm nhân viên";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ibtTimTaiKhoan
            // 
            this.ibtTimTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtTimTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtTimTaiKhoan.IconColor = System.Drawing.Color.Black;
            this.ibtTimTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtTimTaiKhoan.IconSize = 35;
            this.ibtTimTaiKhoan.Location = new System.Drawing.Point(1, 130);
            this.ibtTimTaiKhoan.Name = "ibtTimTaiKhoan";
            this.ibtTimTaiKhoan.Size = new System.Drawing.Size(295, 39);
            this.ibtTimTaiKhoan.TabIndex = 27;
            this.ibtTimTaiKhoan.Text = "Tìm";
            this.ibtTimTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtTimTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtTimTaiKhoan.UseVisualStyleBackColor = true;
            this.ibtTimTaiKhoan.Click += new System.EventHandler(this.ibtTimTaiKhoan_Click);
            // 
            // icbtRefresh
            // 
            this.icbtRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icbtRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.icbtRefresh.IconColor = System.Drawing.Color.Black;
            this.icbtRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtRefresh.IconSize = 35;
            this.icbtRefresh.Location = new System.Drawing.Point(723, 164);
            this.icbtRefresh.Name = "icbtRefresh";
            this.icbtRefresh.Size = new System.Drawing.Size(112, 37);
            this.icbtRefresh.TabIndex = 30;
            this.icbtRefresh.Text = "Làm mới";
            this.icbtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtRefresh.UseVisualStyleBackColor = true;
            this.icbtRefresh.Click += new System.EventHandler(this.icbtRefresh_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(371, 164);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(124, 37);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.Text = "Chọn ảnh";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(371, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // icbtEdit
            // 
            this.icbtEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icbtEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icbtEdit.IconColor = System.Drawing.Color.Black;
            this.icbtEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtEdit.IconSize = 35;
            this.icbtEdit.Location = new System.Drawing.Point(626, 164);
            this.icbtEdit.Name = "icbtEdit";
            this.icbtEdit.Size = new System.Drawing.Size(91, 37);
            this.icbtEdit.TabIndex = 23;
            this.icbtEdit.Text = "Sửa";
            this.icbtEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtEdit.UseVisualStyleBackColor = true;
            this.icbtEdit.Click += new System.EventHandler(this.icbtEdit_Click);
            // 
            // icbtAdd
            // 
            this.icbtAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icbtAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icbtAdd.IconColor = System.Drawing.Color.Black;
            this.icbtAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtAdd.IconSize = 35;
            this.icbtAdd.Location = new System.Drawing.Point(527, 164);
            this.icbtAdd.Name = "icbtAdd";
            this.icbtAdd.Size = new System.Drawing.Size(91, 37);
            this.icbtAdd.TabIndex = 22;
            this.icbtAdd.Text = "Thêm";
            this.icbtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtAdd.UseVisualStyleBackColor = true;
            this.icbtAdd.Click += new System.EventHandler(this.icbtAdd_Click);
            // 
            // fQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbThemTaiKhoan);
            this.Controls.Add(this.pnDataQuanLyTaiKhoan);
            this.Name = "fQuanLyNhanVien";
            this.Size = new System.Drawing.Size(1185, 547);
            this.pnDataQuanLyTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDataQuanLyTaiKhoan;
        private System.Windows.Forms.Label lbThemTaiKhoan;
        private System.Windows.Forms.TextBox txbHoVaTen;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.DataGridView dgvListNhanVien;
        private System.Windows.Forms.Label lbTImTheoTenNhanVien;
        private System.Windows.Forms.TextBox txbSearchName;
        private System.Windows.Forms.Label lbHoVaTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label lbTenTaiKhoanThemTaiKhoan;
        private System.Windows.Forms.Label lbMatKhauThemTaiKhoan;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton icbtAdd;
        private FontAwesome.Sharp.IconButton icbtEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSearchSDT;
        private FontAwesome.Sharp.IconButton ibtTimTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIdNhanVien;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbPathAnhDD;
        private FontAwesome.Sharp.IconButton icbtRefresh;
        private System.Windows.Forms.TextBox txbIdAccount;
        private System.Windows.Forms.Label label4;
    }
}
