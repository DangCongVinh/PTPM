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
using Quản_lý_KaiOKen_Shop.DTO;

namespace Quản_lý_KaiOKen_Shop
{
    public partial class fDanhSachNhanVien : DevExpress.XtraEditors.XtraForm
    {
       
        public fDanhSachNhanVien()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            LoadDanhSachNV();
        }
        public void LoadDanhSachNV()
        {
            DataTable datatb = ACCOUNTDAO.Instance.LoadDSNV();
            for (int i = 0; i < datatb.Rows.Count; i++)
            {
                ListViewItem lvs = lvsDanhSachNV.Items.Add(datatb.Rows[i][0].ToString());
                lvs.SubItems.Add(datatb.Rows[i][1].ToString());
                lvs.SubItems.Add(datatb.Rows[i][2].ToString());
                lvs.SubItems.Add(datatb.Rows[i][3].ToString());
                lvs.SubItems.Add(datatb.Rows[i][4].ToString());
                lvs.SubItems.Add(datatb.Rows[i][5].ToString());
            }
        }
        public void InsertNhanVien()
        {
           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            string displayname = txbDisplayname.Text;
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            int ca =Convert.ToInt32( numCaLam.Value);
            int type = (int)numLoaiNhanVien.Value;
            string sodienthoai = txbSodienthoai.Text;
            try
            {
                if (ACCOUNTDAO.Instance.InsertAccount(displayname, username, password, ca, type, sodienthoai) == true && username !="")
                {                  
                    MessageBox.Show("Thêm tài khoản thành công");
                    lvsDanhSachNV.Items.Clear();
                    LoadDanhSachNV();
                    Xoatrang();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm trùng tài khoản hoặc username không được trống");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string username = lvsDanhSachNV.SelectedItems[0].SubItems[1].Text;
            if(username == "")
            {
                MessageBox.Show("Vui lòng chọn 1 tài khoản để xóa", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa " + username + ", có thể sẽ mất rất nhiều dữ liệu liên quan đến hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (lvsDanhSachNV.SelectedItems.Count > 0)
                    {
                        //string username = lvsDanhSachNV.SelectedItems[0].SubItems[1].Text;
                        //MessageBox.Show(lvsDanhSachNV.SelectedItems[0].SubItems[1].Text);

                        txbUsername.ReadOnly = true;
                        if (ACCOUNTDAO.Instance.DeleteAccount(username) == true)
                        {
                            MessageBox.Show("Xóa tài khoản thành công");
                            lvsDanhSachNV.Items.Clear();
                            LoadDanhSachNV();
                            Xoatrang();
                        }
                    }
                }
            }
            
            //if (lvsDanhSachNV.SelectedItems.Count > 0)
            //{
            //    string username = lvsDanhSachNV.SelectedItems[0].SubItems[1].Text;
            //    //MessageBox.Show(lvsDanhSachNV.SelectedItems[0].SubItems[1].Text);
            //    txbUsername.ReadOnly = true;
            //    if (AccountDAO.Instance.DeleteAccount(username) == true)
            //    {
            //        MessageBox.Show("Xóa tài khoản thành công");
            //        lvsDanhSachNV.Items.Clear();
            //        LoadDanhSachNV();
            //        Xoatrang();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Xóa tài khoản thất bại");
            //    }
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvsDanhSachNV.SelectedItems.Count > 0)
            {
                txbUsername.ReadOnly = true;
                string displayname = txbDisplayname.Text;
                string username = txbUsername.Text;
                string password = txbPassword.Text;
                int ca =Convert.ToInt32(numCaLam.Value);
                int type = (int)numLoaiNhanVien.Value;
                string sodienthoai = txbSodienthoai.Text;
                if (ACCOUNTDAO.Instance.UpdateAccount(displayname, password, ca, type, sodienthoai, username) == true)
                {
                    MessageBox.Show("Cập nhật thành công");
                    lvsDanhSachNV.Items.Clear();
                    LoadDanhSachNV();
                    Xoatrang();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void lvsDanhSachNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsDanhSachNV.SelectedItems.Count > 0)
            {
                txbUsername.ReadOnly = true;
                txbDisplayname.Text = lvsDanhSachNV.SelectedItems[0].SubItems[0].Text;
                txbUsername.Text= lvsDanhSachNV.SelectedItems[0].SubItems[1].Text;
                txbPassword.Text= lvsDanhSachNV.SelectedItems[0].SubItems[2].Text;
                numCaLam.Value= Convert.ToInt32(lvsDanhSachNV.SelectedItems[0].SubItems[3].Text);
                numLoaiNhanVien.Value = Convert.ToInt32(lvsDanhSachNV.SelectedItems[0].SubItems[4].Text);
                txbSodienthoai.Text= lvsDanhSachNV.SelectedItems[0].SubItems[5].Text;
            }
        }
        public void Xoatrang()
        {
            txbUsername.Text = "";
            txbDisplayname.Text = "";
            txbPassword.Text = "";
            txbSodienthoai.Text = "";
            numCaLam.Value = 1;
            numLoaiNhanVien.Value = 0;
            txbUsername.ReadOnly = false;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            Xoatrang();
        }

        private void txbCa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txbSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void txbSodienthoai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) { e.Handled = true; }
        }
    }
}