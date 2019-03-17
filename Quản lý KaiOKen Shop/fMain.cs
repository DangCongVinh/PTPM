using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quản_lý_KaiOKen_Shop.DTO;
using Quản_lý_KaiOKen_Shop.DAO;
using System.Diagnostics;

namespace Quản_lý_KaiOKen_Shop
{
    public partial class fMain : DevExpress.XtraEditors.XtraForm
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; CheckType(loginAccount.Type); }
        }

        public fMain(Account acc)
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString();

            this.LoginAccount = acc;

            Account LoginAccount = this.LoginAccount;
            var f = new fQuanLyKaiOKen(LoginAccount);
            if (ExistForm(f) == true) return;
            f.MdiParent = this;
            f.Show();
        }

        void CheckType(int type)
        {
            ribAdmin.Visible = type == 1;
        }
        private void barbtnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Account LoginAccount = this.LoginAccount;
            var f = new fQuanLyKaiOKen(LoginAccount);
            if (ExistForm(f) == true) return;
            f.MdiParent = this;
            f.Show();
        }
        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barbtnDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new fDatHang();
            if (ExistForm(f) == true) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barbtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                fLogin f = new fLogin();
                f.ShowDialog();
                this.Close();
            }
        }

        private void barbtnThongTinNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fThongTinNhanVien f = new fThongTinNhanVien();
            f.ShowDialog();
        }

        private void barbtnDanhSachNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new fDanhSachNhanVien();
            if (ExistForm(f) == true) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barbtnThongTinKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fThongTinKhachHang f = new fThongTinKhachHang();
            f.ShowDialog();
        }

        private void barbtnAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fThongTinAdmin f = new fThongTinAdmin();
            f.ShowDialog();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void barbtnAdminThemSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new fAdmin_Thêm_sản_phẩm();
            if (ExistForm(f) == true) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barbtnAdminDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                fLogin f = new fLogin();
                f.ShowDialog();
                this.Close();
            }
        }


        private void barbtnSPTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new fSPTK();
            if (ExistForm(f) == true) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barbtnQuanlyloaigiay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new fQuanlyloaigiay();
            if (ExistForm(f) == true) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barbtnTinhhinhHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new fTinhhinhHD();
            if (ExistForm(f) == true) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnFacebook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100009646444798");
        }

        private void barbtnThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new fThongKe();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barbtnDaBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new fDaBan();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("https://mail.google.com");
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("https://www.google.com/maps/place/Hutech/@10.8561423,106.7828657,17z/data=!3m1!4b1!4m5!3m4!1s0x3175276e6385bd87:0x4911cb0a6db60f3b!8m2!3d10.856137!4d106.7850544?hl=vi-VN");
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel skin = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            skin.LookAndFeel.SkinName = "Xmas 2008 Blue";
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "E:\\Help\\Help.chm");
        }
    }

        
}
