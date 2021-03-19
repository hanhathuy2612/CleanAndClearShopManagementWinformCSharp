namespace Laundry_shop_manager
{
    partial class fQuanykhachhang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.Label();
            this.lbSDTKhachHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbIdKhach = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txbSoDienThoaiKH = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbTenKhachHang = new System.Windows.Forms.TextBox();
            this.grbTmKhachHang = new System.Windows.Forms.GroupBox();
            this.txbTimTheoSDTKH = new System.Windows.Forms.TextBox();
            this.txbTimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ibtSearch = new FontAwesome.Sharp.IconButton();
            this.lbten = new System.Windows.Forms.Label();
            this.icbtRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtUpdate = new FontAwesome.Sharp.IconButton();
            this.ibtAdd = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbTmKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 347);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenKhachHang.Location = new System.Drawing.Point(6, 65);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(35, 19);
            this.lbTenKhachHang.TabIndex = 1;
            this.lbTenKhachHang.Text = "Tên";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.AutoSize = true;
            this.txtDiaChiKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(6, 103);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(60, 19);
            this.txtDiaChiKH.TabIndex = 2;
            this.txtDiaChiKH.Text = "Địa chỉ ";
            // 
            // lbSDTKhachHang
            // 
            this.lbSDTKhachHang.AutoSize = true;
            this.lbSDTKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSDTKhachHang.Location = new System.Drawing.Point(6, 142);
            this.lbSDTKhachHang.Name = "lbSDTKhachHang";
            this.lbSDTKhachHang.Size = new System.Drawing.Size(95, 19);
            this.lbSDTKhachHang.TabIndex = 3;
            this.lbSDTKhachHang.Text = "Số điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbIdKhach);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.txbSoDienThoaiKH);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.txbTenKhachHang);
            this.groupBox1.Controls.Add(this.lbTenKhachHang);
            this.groupBox1.Controls.Add(this.lbSDTKhachHang);
            this.groupBox1.Controls.Add(this.txtDiaChiKH);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txbIdKhach
            // 
            this.txbIdKhach.Location = new System.Drawing.Point(127, 30);
            this.txbIdKhach.Name = "txbIdKhach";
            this.txbIdKhach.ReadOnly = true;
            this.txbIdKhach.Size = new System.Drawing.Size(59, 20);
            this.txbIdKhach.TabIndex = 7;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb.Location = new System.Drawing.Point(6, 31);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(27, 19);
            this.lb.TabIndex = 6;
            this.lb.Text = "ID";
            // 
            // txbSoDienThoaiKH
            // 
            this.txbSoDienThoaiKH.Location = new System.Drawing.Point(127, 143);
            this.txbSoDienThoaiKH.Name = "txbSoDienThoaiKH";
            this.txbSoDienThoaiKH.Size = new System.Drawing.Size(158, 20);
            this.txbSoDienThoaiKH.TabIndex = 5;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(127, 102);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(342, 20);
            this.txbDiaChi.TabIndex = 5;
            // 
            // txbTenKhachHang
            // 
            this.txbTenKhachHang.Location = new System.Drawing.Point(127, 64);
            this.txbTenKhachHang.Name = "txbTenKhachHang";
            this.txbTenKhachHang.Size = new System.Drawing.Size(280, 20);
            this.txbTenKhachHang.TabIndex = 4;
            // 
            // grbTmKhachHang
            // 
            this.grbTmKhachHang.Controls.Add(this.txbTimTheoSDTKH);
            this.grbTmKhachHang.Controls.Add(this.txbTimKiemTheoTen);
            this.grbTmKhachHang.Controls.Add(this.label2);
            this.grbTmKhachHang.Controls.Add(this.ibtSearch);
            this.grbTmKhachHang.Controls.Add(this.lbten);
            this.grbTmKhachHang.Location = new System.Drawing.Point(730, 43);
            this.grbTmKhachHang.Name = "grbTmKhachHang";
            this.grbTmKhachHang.Size = new System.Drawing.Size(439, 110);
            this.grbTmKhachHang.TabIndex = 5;
            this.grbTmKhachHang.TabStop = false;
            this.grbTmKhachHang.Text = "Tìm thông tin khách hàng";
            // 
            // txbTimTheoSDTKH
            // 
            this.txbTimTheoSDTKH.Location = new System.Drawing.Point(142, 64);
            this.txbTimTheoSDTKH.Name = "txbTimTheoSDTKH";
            this.txbTimTheoSDTKH.Size = new System.Drawing.Size(187, 20);
            this.txbTimTheoSDTKH.TabIndex = 6;
            // 
            // txbTimKiemTheoTen
            // 
            this.txbTimKiemTheoTen.Location = new System.Drawing.Point(142, 26);
            this.txbTimKiemTheoTen.Name = "txbTimKiemTheoTen";
            this.txbTimKiemTheoTen.Size = new System.Drawing.Size(187, 20);
            this.txbTimKiemTheoTen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm theo SDT";
            // 
            // ibtSearch
            // 
            this.ibtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtSearch.IconColor = System.Drawing.Color.Black;
            this.ibtSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtSearch.IconSize = 30;
            this.ibtSearch.Location = new System.Drawing.Point(342, 41);
            this.ibtSearch.Name = "ibtSearch";
            this.ibtSearch.Size = new System.Drawing.Size(91, 34);
            this.ibtSearch.TabIndex = 7;
            this.ibtSearch.Text = "Tìm";
            this.ibtSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtSearch.UseVisualStyleBackColor = true;
            this.ibtSearch.Click += new System.EventHandler(this.ibtSearch_Click);
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbten.Location = new System.Drawing.Point(20, 27);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(93, 19);
            this.lbten.TabIndex = 2;
            this.lbten.Text = "Tìm theo tên";
            // 
            // icbtRefresh
            // 
            this.icbtRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtRefresh.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.icbtRefresh.IconColor = System.Drawing.Color.Black;
            this.icbtRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtRefresh.IconSize = 30;
            this.icbtRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtRefresh.Location = new System.Drawing.Point(572, 137);
            this.icbtRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.icbtRefresh.Name = "icbtRefresh";
            this.icbtRefresh.Size = new System.Drawing.Size(105, 38);
            this.icbtRefresh.TabIndex = 10;
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
            this.ibtUpdate.Location = new System.Drawing.Point(572, 82);
            this.ibtUpdate.Name = "ibtUpdate";
            this.ibtUpdate.Size = new System.Drawing.Size(105, 34);
            this.ibtUpdate.TabIndex = 8;
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
            this.ibtAdd.Location = new System.Drawing.Point(572, 29);
            this.ibtAdd.Name = "ibtAdd";
            this.ibtAdd.Size = new System.Drawing.Size(105, 34);
            this.ibtAdd.TabIndex = 6;
            this.ibtAdd.Text = "Thêm";
            this.ibtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtAdd.UseVisualStyleBackColor = true;
            this.ibtAdd.Click += new System.EventHandler(this.ibtAdd_Click);
            // 
            // fQuanykhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.icbtRefresh);
            this.Controls.Add(this.ibtUpdate);
            this.Controls.Add(this.ibtAdd);
            this.Controls.Add(this.grbTmKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "fQuanykhachhang";
            this.Size = new System.Drawing.Size(1185, 547);
            this.Load += new System.EventHandler(this.fQuanykhachhang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbTmKhachHang.ResumeLayout(false);
            this.grbTmKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.Label txtDiaChiKH;
        private System.Windows.Forms.Label lbSDTKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSoDienThoaiKH;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbTenKhachHang;
        private System.Windows.Forms.GroupBox grbTmKhachHang;
        private System.Windows.Forms.TextBox txbTimTheoSDTKH;
        private System.Windows.Forms.TextBox txbTimKiemTheoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbten;
        private FontAwesome.Sharp.IconButton ibtAdd;
        private FontAwesome.Sharp.IconButton ibtSearch;
        private FontAwesome.Sharp.IconButton ibtUpdate;
        private FontAwesome.Sharp.IconButton icbtRefresh;
        private System.Windows.Forms.TextBox txbIdKhach;
        private System.Windows.Forms.Label lb;
    }
}
