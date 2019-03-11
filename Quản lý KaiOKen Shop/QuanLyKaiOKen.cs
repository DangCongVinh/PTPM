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
using DevExpress.XtraReports.UI;

namespace Quản_lý_KaiOKen_Shop
{
    public partial class fQuanLyKaiOKen : DevExpress.XtraEditors.XtraForm
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value;/* Thongtin(loginAccount.Ca,loginAccount.Type,loginAccount.DisplayName); */}
        }
        public fQuanLyKaiOKen(Account acc)//Account acc
        {
            InitializeComponent();

            LoadSPTK();
            this.LoginAccount = acc;
        }
        #region Event // nơi viết sự kiện


        //public void Thongtin(string displayname, int ca, int type)
        //{
        //    lblTenNhanVien.Text = loginAccount.DisplayName;
        //    lblLoaiCongViec.Text = Convert.ToInt32(loginAccount.Type).ToString();
        //    lblCaLam.Text = Convert.ToInt32(loginAccount.Ca).ToString();
        //}
        private void fQuanLyKaiOKen_Load(object sender, EventArgs e)
        {
            lblTenNhanVien.Text = loginAccount.DisplayName;
            lblLoaiCongViec.Text = Convert.ToInt32(loginAccount.Type).ToString();
            lblCaLam.Text = Convert.ToInt32(loginAccount.Ca).ToString();
            //lblTenNhanVien.DataBindings.Add("text", AccountDAO.Instance.LoadDSNV(), "Displayname");
            //lblLoaiCongViec.DataBindings.Add("text", AccountDAO.Instance.LoadDSNV(), "type");
            //lblCaLam.DataBindings.Add("text", AccountDAO.Instance.LoadDSNV(), "ca");
            if (lblLoaiCongViec.Text == "1")
            {
                lblLoaiCongViec.Text = "ADMIN";
            }
            else
            {
                lblLoaiCongViec.Text = "Nhân viên";
            }
        }

        private void txbNhapMaHang_TextChanged(object sender, EventArgs e)
        {
            string mahang = txbNhapMaHang.Text;
            if (checkmahang(mahang) == true)//
            {
                listViewGia1sp.Clear();
                ListViewItem list = listViewGia1sp.Items.Add(THONGTINGIAYDAO.Instance.gia(mahang).Rows[0].ItemArray[3].ToString() + "đ");
            }
            else
            {
                listViewGia1sp.Clear();
            }
            //if (listViewSanPham.Items.Count > 0 && txbHoaDon.Text == "0")
            //{
            //    MessageBox.Show("Xin đừng nhập quá nhanh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    focus_and_xoarong();
            //}
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            int tong = 0;
            string mahang = txbNhapMaHang.Text;
            DataTable datatb = THONGTINGIAYDAO.Instance.gia(mahang);
            if (checkmahang(mahang) == true && CheckExist(mahang) == -1)
            {
                ListViewItem lvs = listViewSanPham.Items.Add(datatb.Rows[0].ItemArray[0].ToString());
                lvs.SubItems.Add(datatb.Rows[0].ItemArray[1].ToString());
                lvs.SubItems.Add(datatb.Rows[0].ItemArray[2].ToString());
                lvs.SubItems.Add(DateTime.Now.ToShortDateString());
                lvs.SubItems.Add(datatb.Rows[0].ItemArray[3].ToString());
                for (int i = 0; i < listViewSanPham.Items.Count; i++)
                {
                    tong = tong + int.Parse(listViewSanPham.Items[i].SubItems[4].Text);
                }
            }
            else
            {
                MessageBox.Show("Sai mã hàng hoặc mã hàng đã được thêm vào hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            focus_and_xoarong();
            txbHoaDon.Text = tong.ToString();
            txbGiamGia.Focus();

        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (listViewSanPham.SelectedItems.Count > 0)
            {
                string mahang = txbNhapMaHang.Text;
                listViewSanPham.Items.Remove(listViewSanPham.SelectedItems[0]);
                txbHoaDon.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void HamCatChuoi()
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int tienthua = 0;
            if (txbTienNhan.Text != "")
            {
                if (txbGiamGia.Text == "")
                {
                    int a = 0;
                    txbGiamGia.Text = a.ToString();
                }
                tienthua = int.Parse(txbTienNhan.Text) - int.Parse(txbHoaDon.Text) + (int.Parse(txbGiamGia.Text) * int.Parse(txbHoaDon.Text)) / 100;
                txbTienThua.Text = tienthua.ToString() + "đ";
            }
        }

        public bool BanLe = false;

        private void btnBanLe_Click(object sender, EventArgs e)
        {
            decimal tong = 0;
            if (txbHoaDon.Text == "")
            {
                tong = tong + numerUpDown.Value * Convert.ToInt32(SPBLDAO.Instance.LoadSPTK().Rows[comboBoxSPTK.SelectedIndex].ItemArray[2]);
                //MessageBox.Show(comboBoxSPTK.SelectedIndex.ToString());
            }
            else
            {
                tong = tong + numerUpDown.Value * Convert.ToInt32(SPBLDAO.Instance.LoadSPTK().Rows[comboBoxSPTK.SelectedIndex].ItemArray[2]) + Convert.ToInt32(txbHoaDon.Text);
            }
            txbHoaDon.Text = tong.ToString();
            BanLe = true;
            labelControl11.Text = "Bạn đã thêm " + numerUpDown.Value.ToString() + " " + SPBLDAO.Instance.LoadSPTK().Rows[comboBoxSPTK.SelectedIndex].ItemArray[1].ToString() + " vào hóa đơn";
        }
        #endregion

        #region Phương thức tạo thêm // viết phương thức tạo thêm
        public int CheckExist(string mahang)
        {
            int dong = -1;
            for (int i = 0; i < listViewSanPham.Items.Count; i++)
            {
                if (listViewSanPham.Items[i].SubItems[0].Text == mahang)
                {
                    dong = i;
                    i++;
                }
            }
            return dong;
        }

        public void focus_and_xoarong()
        {
            txbNhapMaHang.Text = "";
            txbNhapMaHang.Focus();
        }

        bool checkmahang(string mahang)
        {
            return THONGTINGIAYDAO.Instance.checkMaHang(mahang);
        }

        public void LoadSPTK()
        {
            DataTable datatb = SPBLDAO.Instance.LoadSPTK();
            comboBoxSPTK.DisplayMember = "Ten_SPKM";
            comboBoxSPTK.ValueMember = "ID_SPBL";
            comboBoxSPTK.DataSource = datatb;
        }
        #endregion

        private void BtnTang_Click(object sender, EventArgs e)
        {
            //lblTangSPTK.Text="Đã tặng "+ numerUpDown.Value.ToString() + " " + SanPhamTangKemDAO.Instance.LoadSPTK().Rows[comboBoxSPTK.SelectedIndex].ItemArray[0].ToString();
        }
        private void lblLoaiCongViec_Click(object sender, EventArgs e)
        {

        }

        private void txbGiamGia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (listViewSanPham.Items.Count > 0)
            {
                string ngaytao = DateTime.Now.ToString();
                int tongtien = Convert.ToInt32(txbHoaDon.Text) - (Convert.ToInt32(txbHoaDon.Text) * Convert.ToInt32(txbGiamGia.Text)) / 100;
                string username = loginAccount.UserName;
                if (HOADDONDAO.Instance.InsertHD(ngaytao, tongtien, username))
                {
                    // Bán giày và thêm bán lẻ
                    // Khai báo ID_HD
                    if (BanLe == true)
                    {
                        int id_spbl = (int)comboBoxSPTK.SelectedValue;
                        int id_hd = HOADDONDAO.Instance.GetMaxIDBill();
                        for (int i = 0; i < listViewSanPham.Items.Count; i++)
                        {
                            string id_giay = listViewSanPham.Items[i].Text;
                            if (txbGiamGia.Text == "" || txbGiamGia.Text == "0")
                            {
                                int id_discount = 4;//discount == 0
                                CHITIETHDDAO.Instance.InsertCTHDByMaxID(id_hd, id_giay, id_spbl, id_discount, (int)numerUpDown.Value);
                                THONGTINGIAYDAO.Instance.UpdateStatus(id_giay);
                            }
                            else
                            {
                                //discount == mã km
                                int id_discount = Convert.ToInt32(DISCOUNTDAO.Instance.GetNewDiscountLV().Rows[0][0].ToString());
                                CHITIETHDDAO.Instance.InsertCTHDByMaxID(id_hd, id_giay, id_spbl, id_discount, (int)numerUpDown.Value);
                                THONGTINGIAYDAO.Instance.UpdateStatus(id_giay);
                            }
                        }
                        int soluongtrongkho = Convert.ToInt32(SPBLDAO.Instance.SELECTALL(id_spbl).Rows[0][3]);
                        int soluongmoi = 0;
                        soluongmoi = soluongmoi + soluongtrongkho - (int)numerUpDown.Value;
                        SPBLDAO.Instance.UpdateSL(soluongmoi, id_spbl);
                    }
                    else
                    {
                        //bán giày nhưng k bán lẻ
                        //Bán lẻ = false
                        int id_spbl = 1003;
                        int id_hd = HOADDONDAO.Instance.GetMaxIDBill();
                        for (int i = 0; i < listViewSanPham.Items.Count; i++)
                        {
                            int slspbl = 0;
                            string id_giay = listViewSanPham.Items[i].Text;
                            if (txbGiamGia.Text == "" || txbGiamGia.Text == "0")
                            {
                                int id_discount = 4;
                                CHITIETHDDAO.Instance.InsertCTHDByMaxID(id_hd, id_giay, id_spbl, id_discount, slspbl);
                                THONGTINGIAYDAO.Instance.UpdateStatus(id_giay);
                            }
                        }
                    }
                }
            }
            else
            {
                // bán lẻ nhưng k bán giày// chỉ bán lẻ
                if (BanLe == true)
                {
                    string ngaytao = DateTime.Now.ToString();
                    int tongtien = Convert.ToInt32(txbHoaDon.Text);
                    string username = loginAccount.UserName;
                    if (HOADDONDAO.Instance.InsertHD(ngaytao, tongtien, username))
                    {
                        int id_spbl = (int)comboBoxSPTK.SelectedValue;
                        int id_hd = HOADDONDAO.Instance.GetMaxIDBill();
                        int slspbl = (int)numerUpDown.Value;
                        string id_giay = "Không";
                        if (txbGiamGia.Text == "" || txbGiamGia.Text == "0")
                        {
                            int id_discount = 4;
                            CHITIETHDDAO.Instance.InsertCTHDByMaxID(id_hd, id_giay, id_spbl, id_discount, slspbl);
                            THONGTINGIAYDAO.Instance.UpdateStatus(id_giay);
                        }
                        int soluongtrongkho = Convert.ToInt32(SPBLDAO.Instance.SELECTALL(id_spbl).Rows[0][3]);
                        int soluongmoi = 0;
                        soluongmoi = soluongmoi + soluongtrongkho - (int)numerUpDown.Value;
                        SPBLDAO.Instance.UpdateSL(soluongmoi, id_spbl);
                        //ThongTinGiayDAO.Instance.DeleteGiay(id_giay);
                    }
                }
            }
            MessageBox.Show("Xuất hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
            BanLe = false;
            focus_and_xoarong();
            listViewSanPham.Items.Clear();
            txbGiamGia.Text = "";
            txbHoaDon.Text = "";
            txbTienNhan.Text = "";
            txbTienThua.Text = "";
            LoadSPTK();
            //Xuất hóa đơn
            //ReportBills bill = new ReportBills();

            //bill.DataSource = HOADDONDAO.Instance.GetReportBill(id_hd);

            //bill.ShowPreviewDialog();
        }


        private void txbMaKM_TextChanged(object sender, EventArgs e)
        {
            string sdtkm = txbMaKM.Text;
            txbGiamGia.Text = "0";
            DataTable datatb = KHACHHANGDAO.Instance.CheckMaKM(sdtkm);
            for (int i = 0; i < datatb.Rows.Count; i++)
            {
                if (datatb.Rows[0][0].ToString() == sdtkm)
                {
                    txbGiamGia.Text = DISCOUNTDAO.Instance.GetNewDiscountLV().Rows[0][1].ToString();
                }
            }
        }

        private void btnThemMaKM_Click(object sender, EventArgs e)
        {
            try
            {
                string sdtkm = txbMaKM.Text;
                if (KHACHHANGDAO.Instance.InsertMaKM(sdtkm))
                {
                    lblThemMaKM.Text = "Thêm mã " + sdtkm + " thành công";
                }
            }
            catch
            {
                MessageBox.Show("Số điện thoại khuyến mãi này đã tồn tại!", "Thông báo");
            }
            txbMaKM.Text = "";
        }
    }
}