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
using Quản_lý_KaiOKen_Shop.DTO;
using Quản_lý_KaiOKen_Shop.DAO;

namespace Quản_lý_KaiOKen_Shop
{
    public partial class fQuanlyloaigiay : DevExpress.XtraEditors.XtraForm
    {
        public fQuanlyloaigiay()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            LoadLoaiGiay();
        }

        public void LoadLoaiGiay()
        {
            for (int i = 0; i < CatarogryDAO.Instance.LoadLoaiGiay().Rows.Count; i++)
            {
                ListViewItem lvs = lvsLoaiGiay.Items.Add(CatarogryDAO.Instance.LoadLoaiGiay().Rows[i][0].ToString());
                lvs.SubItems.Add(CatarogryDAO.Instance.LoadLoaiGiay().Rows[i][1].ToString());
            }
        }

        private void lvsLoaiGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsLoaiGiay.SelectedItems.Count > 0)
            {
                txbTenLoaigiay.Text = lvsLoaiGiay.SelectedItems[0].SubItems[1].Text;
            }
        }

        

        private void btnAdminThemSanPham_Click(object sender, EventArgs e)
        {
            //string ten1 = txbTenLoaigiay.Text.ToUpper();
            //string ten3 = "";
            //for (int i = 0; i < lvsLoaiGiay.Items.Count; i++)
            //{
            //    string ten2 = lvsLoaiGiay.Items[i].SubItems[1].Text.ToUpper();
            //    if (ten1 == ten2)
            //    {
            //        ten3 = ten1;
            //    }
            //}
            //if (txbTenLoaigiay.Text != "" && ten1 == ten3)
            //{
            //    string tenloaigiay = txbTenLoaigiay.Text;
            //    if (CatarogryDAO.Instance.InsertLoaiGiay(tenloaigiay) == true)
            //    {
            //        lblThongbao.Text = "Thêm " + tenloaigiay + " thành công";
            //        lvsLoaiGiay.Items.Clear();
            //        LoadLoaiGiay();
            //        Xoatrang();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thất bại");
            //    }
            //}
            if (txbTenLoaigiay.Text != "")
            {
                string tenloaigiay = txbTenLoaigiay.Text;
                if (CatarogryDAO.Instance.InsertLoaiGiay(tenloaigiay) == true)
                {
                    lblThongbao.Text = "Thêm " + tenloaigiay + " thành công";
                    lvsLoaiGiay.Items.Clear();
                    LoadLoaiGiay();
                    Xoatrang();
                }
                else
                {
                    lblThongbao.Text = "Thêm " + tenloaigiay + " thất bại";
                }
            }
        }

        public void Xoatrang() { txbTenLoaigiay.Text = ""; }
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            Xoatrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenloaigiay = lvsLoaiGiay.SelectedItems[0].SubItems[1].Text;
            if (MessageBox.Show("Bạn có muốn xóa " + tenloaigiay + " không, có thể bạn sẽ mất dữ liệu ở hóa đơn và chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (lvsLoaiGiay.SelectedItems.Count > 0)
                {

                    if (CatarogryDAO.Instance.DeleteLoaiGiay(tenloaigiay) == true)
                    {
                        lblThongbao.Text = "Xóa " + tenloaigiay + " thành công";
                        lvsLoaiGiay.Items.Clear();
                        LoadLoaiGiay();
                        Xoatrang();
                    }
                }
            }

            //try
            //{
            //    if (lvsLoaiGiay.SelectedItems.Count > 0)
            //    {
            //        string tenloaigiay = lvsLoaiGiay.SelectedItems[0].SubItems[1].Text;
            //        if (CatarogryDAO.Instance.DeleteLoaiGiay(tenloaigiay) == true)
            //        {
            //            lblThongbao.Text = "Xóa " + tenloaigiay + " thành công";
            //            lvsLoaiGiay.Items.Clear();
            //            LoadLoaiGiay();
            //            Xoatrang();
            //        }
            //        else
            //        {
            //            lblThongbao.Text = "Xóa " + tenloaigiay + " thất bại";
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Bạn có ")
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvsLoaiGiay.SelectedItems.Count > 0)
            {
                string tenloaigiay = txbTenLoaigiay.Text;
                int id = Convert.ToInt32(lvsLoaiGiay.SelectedItems[0].SubItems[0].Text);
                //MessageBox.Show(id.ToString());
                if (CatarogryDAO.Instance.UpdateLoaiGiay(tenloaigiay, id))
                {
                    lblThongbao.Text = "Update " + tenloaigiay + " thành công";
                    lvsLoaiGiay.Items.Clear();
                    LoadLoaiGiay();
                    Xoatrang();
                }
                else
                {
                    lblThongbao.Text = "Update " + tenloaigiay + " thất bại";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}