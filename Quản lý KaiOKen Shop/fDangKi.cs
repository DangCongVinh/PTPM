using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quản_lý_KaiOKen_Shop.DAO;

namespace Quản_lý_KaiOKen_Shop
{
    public partial class fDangKi : DevExpress.XtraEditors.XtraForm
    {
        public fDangKi()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string tenhienthi = txtTenHienThi.Text;
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            int ca =(int)numericUpDown1.Value;
            string sdt = txtSoDienThoai.Text;
            try
            {
                if (txtTenHienThi.Text != "" && txtTenDangNhap.Text != "" && txtSoDienThoai.Text != "" && txtMatKhau.Text != "")
                {
                    if (ACCOUNTDAO.Instance.Dangky(tenhienthi, username, password, ca, sdt) == true)
                    {
                        MessageBox.Show("Đăng ký thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã có người sử dụng", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fDangKi_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel skin = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            skin.LookAndFeel.SkinName = "Xmas 2008 Blue";
        }
    }
}