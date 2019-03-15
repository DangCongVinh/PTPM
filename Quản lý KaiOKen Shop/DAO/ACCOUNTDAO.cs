using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quản_lý_KaiOKen_Shop.DTO;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class ACCOUNTDAO
    {
        private static ACCOUNTDAO instance;

        public static ACCOUNTDAO Instance
        {
            get { if (instance == null) instance =new ACCOUNTDAO(); return instance; } 
            private set { instance = value; }
        }
        private ACCOUNTDAO() { }
        public int type;

        public bool _Login(string userName, string passWord)
        {
            //string query = "select username, password, type from Account where UserName=N'"+ userName + "' and Password = N'" + passWord + "'";

            //DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            //    foreach (DataRow item in datatb.Rows){
            //        type = Convert.ToInt32(item["type"]);
            //    }
            //        return datatb.Rows.Count>0;     // trả về true là > 0
            string query = "select * from  Account where UserName=N'" + userName + "' and Password = N'" + passWord + "'";
            
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            if (query.Count() > 0 && datatb.Rows.Count >0)
            {
                return true; }
            else return false;

        }


        public Account Phanquyen(string username)// lấy ra account theo username
        {
            string query = "select*from account where username =N'"+username+"'";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in datatb.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable LoadDSNV()
        {
            string query = "Select*from Account";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
           
            return datatb;
        }
        public bool InsertAccount(string displayname, string username, string password, int ca, int type, string sodienthoai)
        {
            string query = string.Format("insert into Account (DisplayName, UserName,Password,Ca,TYPE,SoDienThoai) values (N'{0}',N'{1}',N'{2}',{3},{4},N'{5}')",displayname,username,password,ca,type,sodienthoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Dangky(string displayname, string username, string password, int ca, string sodienthoai)
        {
            string query = string.Format("insert into Account (DisplayName, UserName,Password,Ca,TYPE,SoDienThoai) values (N'{0}',N'{1}',N'{2}',{3},0,N'{4}')", displayname, username, password, ca, sodienthoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("delete from account where username=N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string displayname, string password, int ca, int type, string sodienthoai, string username)
        {
            string query = string.Format("update account set displayname=N'{0}',password=N'{1}', ca={2},type={3}, sodienthoai=N'{4}' where username = N'{5}'",displayname,password,ca,type,sodienthoai,username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
