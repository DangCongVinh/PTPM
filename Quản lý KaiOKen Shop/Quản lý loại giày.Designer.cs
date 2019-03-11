namespace Quản_lý_KaiOKen_Shop
{
    partial class fQuanlyloaigiay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanlyloaigiay));
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdminThemSanPham = new DevExpress.XtraEditors.SimpleButton();
            this.txbTenLoaigiay = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lvsLoaiGiay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblThongbao = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTrang.ImageOptions.Image")));
            this.btnXoaTrang.Location = new System.Drawing.Point(40, 260);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(96, 43);
            this.btnXoaTrang.TabIndex = 4;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(469, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 51);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(260, 335);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 51);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(137, 335);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 51);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdminThemSanPham
            // 
            this.btnAdminThemSanPham.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnAdminThemSanPham.Appearance.Options.UseForeColor = true;
            this.btnAdminThemSanPham.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdminThemSanPham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminThemSanPham.ImageOptions.Image")));
            this.btnAdminThemSanPham.Location = new System.Drawing.Point(15, 335);
            this.btnAdminThemSanPham.Name = "btnAdminThemSanPham";
            this.btnAdminThemSanPham.Size = new System.Drawing.Size(107, 51);
            this.btnAdminThemSanPham.TabIndex = 1;
            this.btnAdminThemSanPham.Text = "Thêm";
            this.btnAdminThemSanPham.Click += new System.EventHandler(this.btnAdminThemSanPham_Click);
            // 
            // txbTenLoaigiay
            // 
            this.txbTenLoaigiay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenLoaigiay.Location = new System.Drawing.Point(15, 133);
            this.txbTenLoaigiay.Name = "txbTenLoaigiay";
            this.txbTenLoaigiay.Size = new System.Drawing.Size(179, 27);
            this.txbTenLoaigiay.TabIndex = 0;
            this.txbTenLoaigiay.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 16);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Tên loại giày";
            // 
            // lvsLoaiGiay
            // 
            this.lvsLoaiGiay.BackColor = System.Drawing.Color.LightGreen;
            this.lvsLoaiGiay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvsLoaiGiay.FullRowSelect = true;
            this.lvsLoaiGiay.GridLines = true;
            this.lvsLoaiGiay.Location = new System.Drawing.Point(211, 102);
            this.lvsLoaiGiay.Name = "lvsLoaiGiay";
            this.lvsLoaiGiay.Size = new System.Drawing.Size(376, 141);
            this.lvsLoaiGiay.TabIndex = 46;
            this.lvsLoaiGiay.UseCompatibleStateImageBehavior = false;
            this.lvsLoaiGiay.View = System.Windows.Forms.View.Details;
            this.lvsLoaiGiay.SelectedIndexChanged += new System.EventHandler(this.lvsLoaiGiay_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Loại Giay";
            this.columnHeader2.Width = 284;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(230, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(125, 28);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "KaiOKen Shop";
            // 
            // lblThongbao
            // 
            this.lblThongbao.Location = new System.Drawing.Point(211, 249);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(0, 13);
            this.lblThongbao.TabIndex = 48;
            // 
            // fQuanlyloaigiay
            // 
            this.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 427);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lvsLoaiGiay);
            this.Controls.Add(this.txbTenLoaigiay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdminThemSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQuanlyloaigiay";
            this.Text = "Thêm sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnAdminThemSanPham;
        private System.Windows.Forms.TextBox txbTenLoaigiay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ListView lvsLoaiGiay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblThongbao;
    }
}