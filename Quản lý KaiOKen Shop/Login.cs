using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quản_lý_KaiOKen_Shop.DAO;
using Quản_lý_KaiOKen_Shop.DTO;

namespace Quản_lý_KaiOKen_Shop
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }
        //public int type;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //type = AccountDAO.Instance.Phanquyen(type);

            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            Account LoginAccount = ACCOUNTDAO.Instance.Phanquyen(userName);
            if (_Login(userName, passWord) == true)
            {
                this.Hide();
                fMain f = new fMain(LoginAccount);
                //MessageBox.Show("" + AccountDAO.Instance._Login(userName,passWord).Rows[0][2].ToString());
                f.ShowDialog();
                this.Close();
                
            }
            else
            {
                lblSai.Text = "Sai thông tin đăng nhập";
                //MessageBox.Show("Sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txbUsername.Text = "";
                txbPassword.Text = "";
                txbUsername.Focus();
            }
        }

        bool _Login(string userName, string passWord)
        {
            return ACCOUNTDAO.Instance._Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel skin = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            skin.LookAndFeel.SkinName = "Xmas 2008 Blue";
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            fDangKi f = new fDangKi();
            f.ShowDialog();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}