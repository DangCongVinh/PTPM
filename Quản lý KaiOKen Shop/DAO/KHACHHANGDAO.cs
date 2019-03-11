using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class KHACHHANGDAO
    {
        private static KHACHHANGDAO instance;

        public static KHACHHANGDAO Instance
        {
            get { if (instance == null) instance = new KHACHHANGDAO(); return instance; }
            private set { instance = value; }
        }
        public KHACHHANGDAO() { }

        public bool InsertMaKM(string sdtkm)
        {
            string query = "INSERT INTO KHACHHANG VALUES (N'" + sdtkm + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable CheckMaKM(string sdtkm)
        {
            string query = "SELECT*FROM KHACHHANG WHERE sdtkm=N'"+sdtkm+"'";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }

    }
}
