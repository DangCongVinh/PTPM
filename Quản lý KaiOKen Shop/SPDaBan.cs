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
    public partial class fDaBan : DevExpress.XtraEditors.XtraForm
    {
        public fDaBan()
        {
            InitializeComponent();
        }

        private void fDaBan_Load(object sender, EventArgs e)
        {
            LoadSPDaBan();
        }

        public void LoadSPDaBan()
        {
            DataTable datatb = THONGTINGIAYDAO.Instance.SPDaBan();//lấy danh sách các sản phẩm đã bán
            for (int i = 0; i < datatb.Rows.Count; i++)
            {//load lên listview
                ListViewItem lvs = lvsSPDB.Items.Add(datatb.Rows[i][0].ToString());
                lvs.SubItems.Add(datatb.Rows[i][1].ToString());
                lvs.SubItems.Add(datatb.Rows[i][2].ToString());
                lvs.SubItems.Add(datatb.Rows[i][3].ToString());
                lvs.SubItems.Add(datatb.Rows[i][4].ToString());
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            lvsSPDB.Items.Clear();
            LoadSPDaBan();
        }
    }
}