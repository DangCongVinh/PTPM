namespace Quản_lý_KaiOKen_Shop
{
    partial class fSPTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSPTK));
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.lvsSPTK = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbTenSP = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.tbxGiaSPTK = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTrang.Appearance.Options.UseForeColor = true;
            this.btnXoaTrang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXoaTrang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTrang.ImageOptions.Image")));
            this.btnXoaTrang.Location = new System.Drawing.Point(337, 325);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(103, 47);
            this.btnXoaTrang.TabIndex = 61;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // lvsSPTK
            // 
            this.lvsSPTK.BackColor = System.Drawing.Color.LightGreen;
            this.lvsSPTK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvsSPTK.FullRowSelect = true;
            this.lvsSPTK.GridLines = true;
            this.lvsSPTK.Location = new System.Drawing.Point(12, 50);
            this.lvsSPTK.MultiSelect = false;
            this.lvsSPTK.Name = "lvsSPTK";
            this.lvsSPTK.Size = new System.Drawing.Size(411, 242);
            this.lvsSPTK.TabIndex = 59;
            this.lvsSPTK.UseCompatibleStateImageBehavior = false;
            this.lvsSPTK.View = System.Windows.Forms.View.Details;
            this.lvsSPTK.SelectedIndexChanged += new System.EventHandler(this.lvsSPTK_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên SPTK";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá bán lẻ";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 120;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(221, 325);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 47);
            this.btnSua.TabIndex = 48;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(116, 325);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 47);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(8, 325);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 47);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(545, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 47);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(28, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 35);
            this.label8.TabIndex = 44;
            this.label8.Text = "KaiOKen Shop";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(446, 131);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 62;
            this.labelControl1.Text = "Tên sản phẩm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(448, 174);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Giá bán lẻ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(447, 222);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 64;
            this.labelControl3.Text = "Số lượng:";
            // 
            // txbTenSP
            // 
            this.txbTenSP.Location = new System.Drawing.Point(523, 128);
            this.txbTenSP.Name = "txbTenSP";
            this.txbTenSP.Size = new System.Drawing.Size(109, 21);
            this.txbTenSP.TabIndex = 66;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSoLuong.Location = new System.Drawing.Point(523, 221);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(109, 21);
            this.numSoLuong.TabIndex = 67;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoLuong.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbxGiaSPTK
            // 
            this.tbxGiaSPTK.Location = new System.Drawing.Point(523, 171);
            this.tbxGiaSPTK.Name = "tbxGiaSPTK";
            this.tbxGiaSPTK.Size = new System.Drawing.Size(109, 21);
            this.tbxGiaSPTK.TabIndex = 68;
            this.tbxGiaSPTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGiaSPTK_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(446, 248);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(162, 13);
            this.labelControl4.TabIndex = 69;
            this.labelControl4.Text = "Bạn không thể sửa tên sản phẩm.";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(446, 262);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 70;
            this.labelControl5.Text = "Hãy thêm mới";
            // 
            // fSPTK
            // 
            this.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 384);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tbxGiaSPTK);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.txbTenSP);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.lvsSPTK);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSPTK";
            this.Text = "Sản phẩm tặng kèm";
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private System.Windows.Forms.ListView lvsSPTK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txbTenSP;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.TextBox tbxGiaSPTK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}