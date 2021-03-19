namespace Laundry_shop_manager
{
    partial class fTinhTrangGiac
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
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTimTheoSHD = new System.Windows.Forms.Label();
            this.lbTimTheoNgay = new System.Windows.Forms.Label();
            this.dtpkSearchNgay = new System.Windows.Forms.DateTimePicker();
            this.txbSearchSHD = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTrangThaiGiac = new System.Windows.Forms.ComboBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.txbSoHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListHoaDon = new System.Windows.Forms.DataGridView();
            this.icbLamMoi = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvListHoaDon);
            this.panel1.Controls.Add(this.icbLamMoi);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 540);
            this.panel1.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(508, 14);
            this.lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(191, 31);
            this.lb1.TabIndex = 23;
            this.lb1.Text = "Tình trạng giặt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTimTheoSHD);
            this.groupBox2.Controls.Add(this.lbTimTheoNgay);
            this.groupBox2.Controls.Add(this.dtpkSearchNgay);
            this.groupBox2.Controls.Add(this.txbSearchSHD);
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Location = new System.Drawing.Point(44, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(286, 128);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm đơn hàng";
            // 
            // lbTimTheoSHD
            // 
            this.lbTimTheoSHD.AutoSize = true;
            this.lbTimTheoSHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbTimTheoSHD.Location = new System.Drawing.Point(12, 15);
            this.lbTimTheoSHD.Name = "lbTimTheoSHD";
            this.lbTimTheoSHD.Size = new System.Drawing.Size(105, 19);
            this.lbTimTheoSHD.TabIndex = 4;
            this.lbTimTheoSHD.Text = "Tìm theo SHD";
            // 
            // lbTimTheoNgay
            // 
            this.lbTimTheoNgay.AutoSize = true;
            this.lbTimTheoNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbTimTheoNgay.Location = new System.Drawing.Point(12, 50);
            this.lbTimTheoNgay.Name = "lbTimTheoNgay";
            this.lbTimTheoNgay.Size = new System.Drawing.Size(104, 19);
            this.lbTimTheoNgay.TabIndex = 5;
            this.lbTimTheoNgay.Text = "Tìm theo ngày";
            // 
            // dtpkSearchNgay
            // 
            this.dtpkSearchNgay.CustomFormat = "MM-dd-yyyy";
            this.dtpkSearchNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkSearchNgay.Location = new System.Drawing.Point(134, 51);
            this.dtpkSearchNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpkSearchNgay.Name = "dtpkSearchNgay";
            this.dtpkSearchNgay.Size = new System.Drawing.Size(133, 20);
            this.dtpkSearchNgay.TabIndex = 18;
            // 
            // txbSearchSHD
            // 
            this.txbSearchSHD.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbSearchSHD.Location = new System.Drawing.Point(134, 15);
            this.txbSearchSHD.Name = "txbSearchSHD";
            this.txbSearchSHD.Size = new System.Drawing.Size(134, 22);
            this.txbSearchSHD.TabIndex = 7;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(134, 84);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(132, 35);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Tìm";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxTrangThaiGiac);
            this.groupBox1.Controls.Add(this.iconButton4);
            this.groupBox1.Controls.Add(this.txbSoHoaDon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(350, 150);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số hóa đơn";
            // 
            // cbxTrangThaiGiac
            // 
            this.cbxTrangThaiGiac.FormattingEnabled = true;
            this.cbxTrangThaiGiac.Items.AddRange(new object[] {
            "Chưa xong",
            "Xong"});
            this.cbxTrangThaiGiac.Location = new System.Drawing.Point(140, 62);
            this.cbxTrangThaiGiac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTrangThaiGiac.Name = "cbxTrangThaiGiac";
            this.cbxTrangThaiGiac.Size = new System.Drawing.Size(181, 21);
            this.cbxTrangThaiGiac.TabIndex = 20;
            // 
            // iconButton4
            // 
            this.iconButton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(140, 88);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(196, 35);
            this.iconButton4.TabIndex = 15;
            this.iconButton4.Text = "Cập nhật tình trạng đồ";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // txbSoHoaDon
            // 
            this.txbSoHoaDon.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbSoHoaDon.Location = new System.Drawing.Point(140, 23);
            this.txbSoHoaDon.Name = "txbSoHoaDon";
            this.txbSoHoaDon.ReadOnly = true;
            this.txbSoHoaDon.Size = new System.Drawing.Size(86, 22);
            this.txbSoHoaDon.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tình trạng giặt";
            // 
            // dgvListHoaDon
            // 
            this.dgvListHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHoaDon.Location = new System.Drawing.Point(430, 86);
            this.dgvListHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListHoaDon.Name = "dgvListHoaDon";
            this.dgvListHoaDon.RowHeadersWidth = 51;
            this.dgvListHoaDon.RowTemplate.Height = 24;
            this.dgvListHoaDon.Size = new System.Drawing.Size(734, 391);
            this.dgvListHoaDon.TabIndex = 17;
            this.dgvListHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListHoaDon_CellClick);
            // 
            // icbLamMoi
            // 
            this.icbLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icbLamMoi.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.icbLamMoi.IconColor = System.Drawing.Color.Black;
            this.icbLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbLamMoi.IconSize = 30;
            this.icbLamMoi.Location = new System.Drawing.Point(1117, 45);
            this.icbLamMoi.Name = "icbLamMoi";
            this.icbLamMoi.Size = new System.Drawing.Size(46, 36);
            this.icbLamMoi.TabIndex = 14;
            this.icbLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbLamMoi.UseVisualStyleBackColor = true;
            this.icbLamMoi.Click += new System.EventHandler(this.icbLamMoi_Click);
            // 
            // fTinhTrangGiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "fTinhTrangGiac";
            this.Size = new System.Drawing.Size(1185, 547);
            this.Load += new System.EventHandler(this.fXemhangtonUsercontrol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTimTheoSHD;
        private System.Windows.Forms.Label lbTimTheoNgay;
        private System.Windows.Forms.TextBox txbSearchSHD;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton icbLamMoi;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.TextBox txbSoHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListHoaDon;
        private System.Windows.Forms.DateTimePicker dtpkSearchNgay;
        private System.Windows.Forms.ComboBox cbxTrangThaiGiac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lb1;
    }
}
