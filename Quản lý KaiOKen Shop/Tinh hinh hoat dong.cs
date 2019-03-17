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
    public partial class fTinhhinhHD : DevExpress.XtraEditors.XtraForm
    {
        public fTinhhinhHD()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            LoadDMY();
            LoadDSHD();
            LoadDTMonth();
            LoadDTDay();
            LoadMaxLG();
            LoadCircleChart();
        }

        public void LoadCircleChart()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            //.DataSource = HOADDONDAO.Instance.CircleChart(month, year);
        }
        public void LoadDMY()
        {
            numNgay.Value = DateTime.Now.Day;
            numThang.Value = DateTime.Now.Month;
            numNam.Value = DateTime.Now.Year;
            lblHDDM.Text = DateTime.Now.ToShortDateString();
            lblCTHDDM.Text = DateTime.Now.ToShortDateString();
        }
        public void LoadDSHD()
        {//tìm danh sách hóa đơn theo ngày/tháng/năm
            int month = (int)numThang.Value; 
            //string ngaymua = datePicker.Value.ToString();
            int day = (int)numNgay.Value;//xem theo ngày
            int year = (int)numNam.Value;
            DataTable datatb = HOADDONDAO.Instance.LoadDSHD(day,month,year);//ngaymua
            for (int i = 0; i < datatb.Rows.Count; i++)
            {
                ListViewItem lvs = lvsHD.Items.Add(datatb.Rows[i][0].ToString());
                lvs.SubItems.Add(datatb.Rows[i][1].ToString());
                lvs.SubItems.Add(datatb.Rows[i][2].ToString());
                lvs.SubItems.Add(datatb.Rows[i][3].ToString());
            }
        }
        public void LoadDTMonth()
        {
            lvsDTMonth.Items.Clear();
            int month =  (int)numThang.Value;
            int year = (int)numNam.Value;
            ListViewItem lvs = lvsDTMonth.Items.Add(string.Format("{0:n0}", HOADDONDAO.Instance.DoanhThuThang(month, year).Rows[0].ItemArray[0].ToString())  + "đ");
            
        }

        public void LoadDTDay()
        {
            lvsDTDay.Items.Clear();
            int month = (int)numThang.Value;
            int day = (int)numNgay.Value;
            int year = (int)numNam.Value;
            //MessageBox.Show("" + day + month + year);
            ListViewItem lvs = lvsDTDay.Items.Add(string.Format("{0:n0}", HOADDONDAO.Instance.DoanhThuDay(month, day, year).Rows[0].ItemArray[0].ToString()) + "đ");
        }

        public void LoadMaxLG()
        {
            int year = (int)numNam.Value;
            int month = (int)numThang.Value;
            for (int i = 0; i < HOADDONDAO.Instance.MaxLG(month, year).Rows.Count; i++)
            {
                ListViewItem lvs = lvsMaxLG.Items.Add(HOADDONDAO.Instance.MaxLG(month, year).Rows[i][1].ToString());
                lvs.SubItems.Add(HOADDONDAO.Instance.MaxLG(month, year).Rows[i][0].ToString());
            }
        }
        private void lvsHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsHD.SelectedItems.Count > 0)
            {
                lvsCTHD.Items.Clear();
                lvsSPBL.Items.Clear();
                int id_hd = Convert.ToInt32(lvsHD.SelectedItems[0].SubItems[0].Text);
                //MessageBox.Show("" + ma_hoadon);
                DataTable datatb = CHITIETHDDAO.Instance.GetCTHDByID_HD(id_hd);
                for (int i = 0; i < datatb.Rows.Count; i++)
                {
                    ListViewItem lvs = lvsCTHD.Items.Add(datatb.Rows[i][0].ToString());
                    lvs.SubItems.Add(datatb.Rows[0][1].ToString());
                    lvs.SubItems.Add(datatb.Rows[i][2].ToString());
                    lvs.SubItems.Add(datatb.Rows[i][3].ToString());
                    lvs.SubItems.Add(datatb.Rows[0][4].ToString());
                    lvs.SubItems.Add(datatb.Rows[i][5].ToString());
                    ///LVS SPBL
                }
                DataTable data = CHITIETHDDAO.Instance.GETSPBL(id_hd);
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    ListViewItem lvi = lvsSPBL.Items.Add(data.Rows[i][0].ToString());
                    lvi.SubItems.Add(data.Rows[i][1].ToString());
                    lvi.SubItems.Add(data.Rows[i][2].ToString());
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            lvsDTMonth.Items.Clear();
            lvsDTDay.Items.Clear();
            lvsHD.Items.Clear();
            lvsCTHD.Items.Clear();
            lvsMaxLG.Items.Clear();
            lvsSPBL.Items.Clear();
            LoadDSHD();
            LoadDTMonth();
            LoadDTDay();
            LoadMaxLG();
            lblHDDM.Text = numNgay.Value.ToString() + "/" + numThang.Value.ToString() + "/" + numNam.Value.ToString();
            lblCTHDDM.Text = lblHDDM.Text;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}