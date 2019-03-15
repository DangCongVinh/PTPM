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
using System.Data.SqlClient;
using Quản_lý_KaiOKen_Shop.DAO;

namespace Quản_lý_KaiOKen_Shop
{
    public partial class fThongTinAdmin : DevExpress.XtraEditors.XtraForm
    {
        public fThongTinAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        
        private void LoadData()
        {
            string query = "SELECT*FROM Account where TYPE=1";
            //DataProvider provider = new DataProvider();
            txbTenAdmin.DataBindings.Add("Text", DataProvider.Instance.ExecuteQuery(query), "DisPlayName");
            txbSoDienThoai.DataBindings.Add("TEXT", DataProvider.Instance.ExecuteQuery(query), "SoDienThoai");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fThongTinAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}