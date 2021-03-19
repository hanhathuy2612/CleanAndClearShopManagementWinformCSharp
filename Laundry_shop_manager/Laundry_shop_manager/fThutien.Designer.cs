namespace Laundry_shop_manager
{
    partial class fThutien
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
            this.dgvListHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenKhach = new System.Windows.Forms.TextBox();
            this.txbSHD = new System.Windows.Forms.TextBox();
            this.ibtTimThuTien = new FontAwesome.Sharp.IconButton();
            this.ibtThuTien = new FontAwesome.Sharp.IconButton();
            this.ibtLamMoiThuTien = new FontAwesome.Sharp.IconButton();
            this.ibtHuyDon = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ibtHuyDon);
            this.panel1.Controls.Add(this.ibtLamMoiThuTien);
            this.panel1.Controls.Add(this.txbTenKhach);
            this.panel1.Controls.Add(this.ibtThuTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ibtTimThuTien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbSHD);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1572, 182);
            this.panel1.TabIndex = 0;
            // 
            // dgvListHoaDon
            // 
            this.dgvListHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHoaDon.Location = new System.Drawing.Point(4, 209);
            this.dgvListHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListHoaDon.Name = "dgvListHoaDon";
            this.dgvListHoaDon.RowHeadersWidth = 51;
            this.dgvListHoaDon.Size = new System.Drawing.Size(1564, 460);
            this.dgvListHoaDon.TabIndex = 0;
            this.dgvListHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListHoaDon_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(64, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(66, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số HD";
            // 
            // txbTenKhach
            // 
            this.txbTenKhach.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbTenKhach.Location = new System.Drawing.Point(169, 108);
            this.txbTenKhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTenKhach.Name = "txbTenKhach";
            this.txbTenKhach.Size = new System.Drawing.Size(344, 26);
            this.txbTenKhach.TabIndex = 6;
            // 
            // txbSHD
            // 
            this.txbSHD.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txbSHD.Location = new System.Drawing.Point(169, 55);
            this.txbSHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSHD.Name = "txbSHD";
            this.txbSHD.Size = new System.Drawing.Size(118, 26);
            this.txbSHD.TabIndex = 8;
            // 
            // ibtTimThuTien
            // 
            this.ibtTimThuTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtTimThuTien.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtTimThuTien.IconColor = System.Drawing.Color.Black;
            this.ibtTimThuTien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtTimThuTien.IconSize = 40;
            this.ibtTimThuTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtTimThuTien.Location = new System.Drawing.Point(544, 71);
            this.ibtTimThuTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtTimThuTien.Name = "ibtTimThuTien";
            this.ibtTimThuTien.Size = new System.Drawing.Size(177, 53);
            this.ibtTimThuTien.TabIndex = 11;
            this.ibtTimThuTien.Text = "Tìm";
            this.ibtTimThuTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtTimThuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtTimThuTien.UseVisualStyleBackColor = true;
            this.ibtTimThuTien.Click += new System.EventHandler(this.ibtTimThuTien_Click);
            // 
            // ibtThuTien
            // 
            this.ibtThuTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtThuTien.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.ibtThuTien.IconColor = System.Drawing.Color.Black;
            this.ibtThuTien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtThuTien.IconSize = 40;
            this.ibtThuTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtThuTien.Location = new System.Drawing.Point(742, 71);
            this.ibtThuTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtThuTien.Name = "ibtThuTien";
            this.ibtThuTien.Size = new System.Drawing.Size(177, 53);
            this.ibtThuTien.TabIndex = 12;
            this.ibtThuTien.Text = "Thu tiền";
            this.ibtThuTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtThuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtThuTien.UseVisualStyleBackColor = true;
            this.ibtThuTien.Click += new System.EventHandler(this.ibtThuTien_Click);
            // 
            // ibtLamMoiThuTien
            // 
            this.ibtLamMoiThuTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtLamMoiThuTien.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.ibtLamMoiThuTien.IconColor = System.Drawing.Color.Black;
            this.ibtLamMoiThuTien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtLamMoiThuTien.IconSize = 40;
            this.ibtLamMoiThuTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtLamMoiThuTien.Location = new System.Drawing.Point(1138, 71);
            this.ibtLamMoiThuTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtLamMoiThuTien.Name = "ibtLamMoiThuTien";
            this.ibtLamMoiThuTien.Size = new System.Drawing.Size(177, 53);
            this.ibtLamMoiThuTien.TabIndex = 13;
            this.ibtLamMoiThuTien.Text = "Làm mới";
            this.ibtLamMoiThuTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtLamMoiThuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtLamMoiThuTien.UseVisualStyleBackColor = true;
            this.ibtLamMoiThuTien.Click += new System.EventHandler(this.ibtLamMoiThuTien_Click);
            // 
            // ibtHuyDon
            // 
            this.ibtHuyDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtHuyDon.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtHuyDon.IconColor = System.Drawing.Color.Black;
            this.ibtHuyDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtHuyDon.IconSize = 40;
            this.ibtHuyDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHuyDon.Location = new System.Drawing.Point(939, 71);
            this.ibtHuyDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtHuyDon.Name = "ibtHuyDon";
            this.ibtHuyDon.Size = new System.Drawing.Size(177, 53);
            this.ibtHuyDon.TabIndex = 14;
            this.ibtHuyDon.Text = "Hủy đơn";
            this.ibtHuyDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHuyDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtHuyDon.UseVisualStyleBackColor = true;
            this.ibtHuyDon.Click += new System.EventHandler(this.ibtHuyDon_Click);
            // 
            // fThutien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvListHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fThutien";
            this.Size = new System.Drawing.Size(1580, 673);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTenKhach;
        private System.Windows.Forms.TextBox txbSHD;
        private FontAwesome.Sharp.IconButton ibtTimThuTien;
        private FontAwesome.Sharp.IconButton ibtThuTien;
        private FontAwesome.Sharp.IconButton ibtLamMoiThuTien;
        private FontAwesome.Sharp.IconButton ibtHuyDon;
    }
}
