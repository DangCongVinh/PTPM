namespace Quản_lý_KaiOKen_Shop
{
    partial class fAdmin_Thêm_sản_phẩm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin_Thêm_sản_phẩm));
            this.label8 = new System.Windows.Forms.Label();
            this.txbAdminTenSanPham = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbAdminGia = new System.Windows.Forms.TextBox();
            this.btnAdminThemSanPham = new DevExpress.XtraEditors.SimpleButton();
            this.txbAdminMaSanPham = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxAdminLoaisp = new System.Windows.Forms.ComboBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.listViewTatCaGiay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lvsSoluonggiay = new System.Windows.Forms.ListView();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txbMucgiamgia = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(90, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 35);
            this.label8.TabIndex = 25;
            this.label8.Text = "KaiOKen Shop";
            // 
            // txbAdminTenSanPham
            // 
            this.txbAdminTenSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbAdminTenSanPham.Location = new System.Drawing.Point(121, 139);
            this.txbAdminTenSanPham.Name = "txbAdminTenSanPham";
            this.txbAdminTenSanPham.Size = new System.Drawing.Size(179, 27);
            this.txbAdminTenSanPham.TabIndex = 2;
            this.txbAdminTenSanPham.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 16);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Tên sản phẩm:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 203);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 16);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Giá:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 265);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 16);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Loại sản phẩm:";
            // 
            // txbAdminGia
            // 
            this.txbAdminGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbAdminGia.Location = new System.Drawing.Point(121, 197);
            this.txbAdminGia.Name = "txbAdminGia";
            this.txbAdminGia.Size = new System.Drawing.Size(179, 27);
            this.txbAdminGia.TabIndex = 3;
            this.txbAdminGia.TabStop = false;
            this.txbAdminGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAdminGia_KeyPress);
            // 
            // btnAdminThemSanPham
            // 
            this.btnAdminThemSanPham.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnAdminThemSanPham.Appearance.Options.UseForeColor = true;
            this.btnAdminThemSanPham.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdminThemSanPham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminThemSanPham.ImageOptions.Image")));
            this.btnAdminThemSanPham.Location = new System.Drawing.Point(20, 368);
            this.btnAdminThemSanPham.Name = "btnAdminThemSanPham";
            this.btnAdminThemSanPham.Size = new System.Drawing.Size(107, 51);
            this.btnAdminThemSanPham.TabIndex = 6;
            this.btnAdminThemSanPham.Text = "Thêm";
            this.btnAdminThemSanPham.Click += new System.EventHandler(this.btnAdminThemSanPham_Click);
            // 
            // txbAdminMaSanPham
            // 
            this.txbAdminMaSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbAdminMaSanPham.Location = new System.Drawing.Point(121, 82);
            this.txbAdminMaSanPham.Name = "txbAdminMaSanPham";
            this.txbAdminMaSanPham.Size = new System.Drawing.Size(179, 27);
            this.txbAdminMaSanPham.TabIndex = 1;
            this.txbAdminMaSanPham.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 16);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Mã sản phẩm:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(142, 368);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 51);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // comboBoxAdminLoaisp
            // 
            this.comboBoxAdminLoaisp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxAdminLoaisp.FormattingEnabled = true;
            this.comboBoxAdminLoaisp.Location = new System.Drawing.Point(121, 256);
            this.comboBoxAdminLoaisp.Name = "comboBoxAdminLoaisp";
            this.comboBoxAdminLoaisp.Size = new System.Drawing.Size(179, 31);
            this.comboBoxAdminLoaisp.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(679, 368);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 51);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(265, 368);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 51);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // listViewTatCaGiay
            // 
            this.listViewTatCaGiay.BackColor = System.Drawing.Color.LightGreen;
            this.listViewTatCaGiay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewTatCaGiay.FullRowSelect = true;
            this.listViewTatCaGiay.GridLines = true;
            this.listViewTatCaGiay.Location = new System.Drawing.Point(317, 12);
            this.listViewTatCaGiay.MultiSelect = false;
            this.listViewTatCaGiay.Name = "listViewTatCaGiay";
            this.listViewTatCaGiay.Size = new System.Drawing.Size(512, 288);
            this.listViewTatCaGiay.TabIndex = 45;
            this.listViewTatCaGiay.UseCompatibleStateImageBehavior = false;
            this.listViewTatCaGiay.View = System.Windows.Forms.View.Details;
            this.listViewTatCaGiay.SelectedIndexChanged += new System.EventHandler(this.listViewTatCaGiay_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID_Giay";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gía";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID_LoaiGiay";
            this.columnHeader4.Width = 100;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTrang.ImageOptions.Image")));
            this.btnXoaTrang.Location = new System.Drawing.Point(45, 293);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(96, 43);
            this.btnXoaTrang.TabIndex = 5;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(317, 306);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(130, 13);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Không thể sửa mã hàng!!!!";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(574, 315);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(118, 13);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "Số lượng giày trong kho:";
            // 
            // lvsSoluonggiay
            // 
            this.lvsSoluonggiay.Location = new System.Drawing.Point(698, 306);
            this.lvsSoluonggiay.Name = "lvsSoluonggiay";
            this.lvsSoluonggiay.Size = new System.Drawing.Size(121, 30);
            this.lvsSoluonggiay.TabIndex = 49;
            this.lvsSoluonggiay.UseCompatibleStateImageBehavior = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(744, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbMucgiamgia
            // 
            this.txbMucgiamgia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbMucgiamgia.Location = new System.Drawing.Point(456, 379);
            this.txbMucgiamgia.Name = "txbMucgiamgia";
            this.txbMucgiamgia.Size = new System.Drawing.Size(94, 27);
            this.txbMucgiamgia.TabIndex = 50;
            this.txbMucgiamgia.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(411, 357);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(137, 16);
            this.labelControl7.TabIndex = 51;
            this.labelControl7.Text = "Nhập mức giảm giá (%)";
            // 
            // btnOk
            // 
            this.btnOk.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnOk.Appearance.Options.UseForeColor = true;
            this.btnOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.ImageOptions.Image")));
            this.btnOk.Location = new System.Drawing.Point(556, 374);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(72, 40);
            this.btnOk.TabIndex = 52;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // fAdmin_Thêm_sản_phẩm
            // 
            this.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 431);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txbMucgiamgia);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lvsSoluonggiay);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.listViewTatCaGiay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.comboBoxAdminLoaisp);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txbAdminMaSanPham);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnAdminThemSanPham);
            this.Controls.Add(this.txbAdminGia);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txbAdminTenSanPham);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAdmin_Thêm_sản_phẩm";
            this.Text = "Thêm sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbAdminTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txbAdminGia;
        private DevExpress.XtraEditors.SimpleButton btnAdminThemSanPham;
        private System.Windows.Forms.TextBox txbAdminMaSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.ComboBox comboBoxAdminLoaisp;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.ListView listViewTatCaGiay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ListView lvsSoluonggiay;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.TextBox txbMucgiamgia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnOk;
    }
}