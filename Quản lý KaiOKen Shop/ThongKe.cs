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
    public partial class fThongKe : DevExpress.XtraEditors.XtraForm
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            int month1 = DateTime.Now.Month;
            int month2 = DateTime.Now.Month+1;
            chart1.DataSource = HOADDONDAO.Instance.ThongKeSLBan(month1, month2);

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngay";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "So luong";

            chart1.Series["Series1"].XValueMember = "NGAYTAO";
            chart1.Series["Series1"].YValueMembers = "SOLUONG";
        }
    }
}