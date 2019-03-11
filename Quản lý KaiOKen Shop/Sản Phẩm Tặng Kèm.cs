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
    public partial class fSPTK : DevExpress.XtraEditors.XtraForm
    {
        public fSPTK()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            Load_SPTK();
        }
        public void Load_SPTK()
        {
            for (int i = 0; i < SanPhamTangKemDAO.Instance.LoadSPTK().Rows.Count; i++)
            {
                ListViewItem lvs = lvsSPTK.Items.Add(SanPhamTangKemDAO.Instance.LoadSPTK().Rows[i][0].ToString());
                lvs.SubItems.Add(SanPhamTangKemDAO.Instance.LoadSPTK().Rows[i][1].ToString());
                lvs.SubItems.Add(SanPhamTangKemDAO.Instance.LoadSPTK().Rows[i][2].ToString());
            }
        }
        public void XoaTrang()
        {
            txbTenSP.Text = "";
            tbxGiaSPTK.Text = "";
            numSoLuong.Value = 20;
            txbTenSP.ReadOnly = false;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void lvsSPTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsSPTK.SelectedItems.Count > 0)
            {
                txbTenSP.ReadOnly = true;
                txbTenSP.Text = lvsSPTK.SelectedItems[0].SubItems[0].Text;
                tbxGiaSPTK.Text = lvsSPTK.SelectedItems[0].SubItems[1].Text;
                numSoLuong.Value = Convert.ToInt32(lvsSPTK.SelectedItems[0].SubItems[2].Text);
            }
        }
        public int CheckExistSPTK()
        {
            int dem = -1;
            for (int i = 0; i < SanPhamTangKemDAO.Instance.LoadSPTK().Rows.Count; i++)
            {
                if (SanPhamTangKemDAO.Instance.LoadSPTK().Rows[i][0].ToString() == txbTenSP.Text  )
                {
                    dem = i;
                    i++;
                }
            }
            return dem;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txbTenSP.Text != "" && tbxGiaSPTK.Text != "")
                {
                    string tensanpham = txbTenSP.Text;
                    int giabanle = int.Parse(tbxGiaSPTK.Text);
                    int soluong = Convert.ToInt32(numSoLuong.Value);
                    if (SanPhamTangKemDAO.Instance.InsertSPTK(tensanpham, giabanle, soluong) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        lvsSPTK.Items.Clear();
                        //if (CheckExistSPTK() != -1)
                        //    SanPhamTangKemDAO.Instance.Update(tensanpham, giabanle, soluong = soluong + (int)numSoLuong.Value);
                        Load_SPTK();
                        XoaTrang();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, có thể do trùng sản phâm", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //
            if (lvsSPTK.SelectedItems.Count > 0)
            {
                //MessageBox.Show(lvsSPTK.SelectedItems[0].SubItems[0].Text);
                string tensanpham = lvsSPTK.SelectedItems[0].SubItems[0].Text;
                if (SanPhamTangKemDAO.Instance.Delete(tensanpham) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    lvsSPTK.Items.Clear();
                    Load_SPTK();
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvsSPTK.SelectedItems.Count > 0)
            {
                string tensanpham = txbTenSP.Text;
                int gia =Convert.ToInt32(tbxGiaSPTK.Text);
                int soluong = Convert.ToInt32(numSoLuong.Value);
                if (SanPhamTangKemDAO.Instance.Update(tensanpham, gia, soluong)==true)
                {
                    MessageBox.Show("Cập nhật thành công");
                    lvsSPTK.Items.Clear();
                    Load_SPTK();
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxGiaSPTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) { e.Handled = true; }
        }
    }
}