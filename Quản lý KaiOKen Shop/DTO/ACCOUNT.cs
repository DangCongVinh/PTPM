using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class Account
    {
        public Account( string displayname, string username, string password, int ca, int type, string sodienthoai)
        {
            this.DisplayName = displayname;
            this.UserName = userName;
            this.PassWord = password;
            this.Ca = ca;
            this.Type = type;
            this.SoDienThoai = sodienthoai;
        }
        public Account(DataRow row)
        {
            this.DisplayName = row["displayname"].ToString();
            this.UserName = row["userName"].ToString();
            this.PassWord = row["password"].ToString();
            this.Ca = (int)row["ca"];
            this.Type = (int)row["type"];
            this.SoDienThoai = row["sodienthoai"].ToString();
        }
        private string soDienThoai;
        private int type;
        private int ca;
        private string passWord;
        private string userName;
        private string displayName;

        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Ca { get => ca; set => ca = value; }
        public int Type { get => type; set => type = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    }
}
