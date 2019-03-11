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
    public partial class fAdmin_Thêm_sản_phẩm : DevExpress.XtraEditors.XtraForm
    {
        public fAdmin_Thêm_sản_phẩm()
        {
            InitializeComponent();
            Load();
            //MessageBox.Show((comboBoxAdminLoaisp.SelectedItem as Catarogry).Id_loaigiay.ToString());

        }
        public void Load()
        {
            LoadLoaiSP();
            LoadKhoHang();
            LoadSoluonggiaytonkho();
        }
        public void LoadLoaiSP()
        {
            List<Catarogry> list = CatarogryDAO.Instance.LoadLoaiHang();
            comboBoxAdminLoaisp.DataSource = list;
            comboBoxAdminLoaisp.DisplayMember = "TenLoaiGiay";
            //comboBoxAdminLoaisp.ValueMember = "ID_LoaiGiay";
        }
        public void LoadKhoHang()
        {
            DataTable datatb = THONGTINGIAYDAO.Instance.TatCaGiay();
            for(int i=0; i < THONGTINGIAYDAO.Instance.TatCaGiay().Rows.Count; i++)
            {
                ListViewItem lvs = listViewTatCaGiay.Items.Add(datatb.Rows[i][0].ToString());
                lvs.SubItems.Add(datatb.Rows[i][1].ToString());
                lvs.SubItems.Add(datatb.Rows[i][2].ToString());
                lvs.SubItems.Add(datatb.Rows[i][3].ToString());
            }
        }
        public void LoadSoluonggiaytonkho()
        {
            lvsSoluonggiay.Items.Add(THONGTINGIAYDAO.Instance.SoluongGiayTrongKho().ToString() +"   \tĐôi");
        }
        private void btnAdminThemSanPham_Click(object sender, EventArgs e)
        {
            // string query = "insert into ThongTinGiay (ID_Giay,TenSanPham,Gia,ID_LoaiGiay) values (N'"+txbAdminMaSanPham.Text+"',N'"+txbAdminTenSanPham.Text+"',"+Convert.ToInt32(txbAdminGia.Text)+",1)";
            // DataProvider.Instance.ExecuteNonQuery(query);
            
            if (txbAdminGia.Text != "" && txbAdminMaSanPham.Text != "" && txbAdminTenSanPham.Text != "")
            {
                string mahang = txbAdminMaSanPham.Text;
                string tensanpham = txbAdminTenSanPham.Text;
                int gia = int.Parse(txbAdminGia.Text);
                int loaigiay = (comboBoxAdminLoaisp.SelectedItem as Catarogry).ID_LoaiGiay;
                try
                {
                    if (THONGTINGIAYDAO.Instance.InsertGiay(mahang, tensanpham, gia, loaigiay) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        listViewTatCaGiay.Items.Clear();
                        LoadKhoHang();
                        txbAdminGia.Text = "";
                        txbAdminMaSanPham.Text = "";
                        txbAdminTenSanPham.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Trùng mã sản phẩm đã có hoặc mã sản phẩm đã bán", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(listViewTatCaGiay.SelectedItems[0].SubItems[0].Text);

            if (listViewTatCaGiay.SelectedItems.Count > 0)
            {
                string mahang = listViewTatCaGiay.SelectedItems[0].SubItems[0].Text.ToString();
                if (THONGTINGIAYDAO.Instance.DeleteGiay(mahang)== true)
                {
                    MessageBox.Show("Xóa thành công");
                    listViewTatCaGiay.Items.Clear();
                    LoadKhoHang();
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
            if (txbAdminGia.Text != "" && txbAdminMaSanPham.Text != "" && txbAdminTenSanPham.Text != "")
            {
                string mahang = txbAdminMaSanPham.Text;
                string tensanpham = txbAdminTenSanPham.Text;
                int gia = Convert.ToInt32(txbAdminGia.Text);
                int loaigiay = (comboBoxAdminLoaisp.SelectedItem as Catarogry).ID_LoaiGiay;
                if (THONGTINGIAYDAO.Instance.UpdateGiay(mahang, tensanpham, gia, loaigiay) == true)
                {
                    MessageBox.Show("Update thành công");
                    listViewTatCaGiay.Items.Clear();
                    LoadKhoHang();
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Update thất bại");
                }
            }
        }

        private void listViewTatCaGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTatCaGiay.SelectedItems.Count > 0)
            {
                txbAdminMaSanPham.ReadOnly = true;
                txbAdminMaSanPham.Text = listViewTatCaGiay.SelectedItems[0].SubItems[0].Text;
                txbAdminTenSanPham.Text = listViewTatCaGiay.SelectedItems[0].SubItems[1].Text;
                txbAdminGia.Text = listViewTatCaGiay.SelectedItems[0].SubItems[2].Text;
                //comboBoxAdminLoaisp.SelectedItem = (comboBoxAdminLoaisp.SelectedItem as Catarogry).ID_LoaiGiay;
                comboBoxAdminLoaisp.SelectedIndex = comboBoxAdminLoaisp.FindString(listViewTatCaGiay.SelectedItems[0].SubItems[3].Text);
                // chưa lấy được tên loại giày khi chọn item qua bên nhập liệu
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }
        void XoaTrang()
        {
            txbAdminMaSanPham.ReadOnly = false;
            txbAdminGia.Text = "";
            txbAdminMaSanPham.Text = "";
            txbAdminTenSanPham.Text = "";
        }
        private void txbAdminGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lvsSoluonggiay.Items.Clear();
            LoadSoluonggiaytonkho();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double discount = Convert.ToDouble(txbMucgiamgia.Text);
            DISCOUNTDAO.Instance.InsertDiscountLV(discount);
            MessageBox.Show("Chọn mức giảm giá là " + discount + " % thành công");
            txbMucgiamgia.Text = "";
        }
    }
}