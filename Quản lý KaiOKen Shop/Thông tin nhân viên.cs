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
    public partial class fThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public fThongTinNhanVien()
        {
            InitializeComponent();
            _LoadDSNV();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void _LoadDSNV()
        {
            //show NV
            string query = "select displayname as [Tên], sodienthoai as [SDT], ca as [Ca làm], type as [Nhân viên] from Account where type = 0";
            dgvThongTinNhanVien.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}