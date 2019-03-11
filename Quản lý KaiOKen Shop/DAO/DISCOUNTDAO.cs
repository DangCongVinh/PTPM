using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class DISCOUNTDAO
    {
        private static DISCOUNTDAO instance;

        public static DISCOUNTDAO Instance
        {
            get { if (instance == null) instance = new DISCOUNTDAO(); return instance; }
            private set { instance = value; }
        }
        public DISCOUNTDAO() { }

        public bool InsertDiscountLV(double discount)
        {
            string query = "INSERT INTO DISCOUNT VALUES (" + discount + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetNewDiscountLV()
        {
            string query = "SELECT*FROM DISCOUNT WHERE ID_DISCOUNT = (SELECT MAX(ID_DISCOUNT) FROM DISCOUNT)";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
    }
}
