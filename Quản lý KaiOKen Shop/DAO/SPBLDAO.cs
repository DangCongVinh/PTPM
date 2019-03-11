using Quản_lý_KaiOKen_Shop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class SPBLDAO
    {
        private static SPBLDAO instance;

        internal static SPBLDAO Instance
        {
            get { if (instance == null) instance = new SPBLDAO(); return instance; }
            private set { instance = value; }
        }
        private SPBLDAO() { }

        public DataTable LoadSPTK()
        {
            DataTable datatb = new DataTable();
            string query = "select*from SPBL where id_spbl <> 1003";
            datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public DataTable SELECTALL(int id_spbl)
        {
            DataTable datatb = new DataTable();
            string query = "select*from SPBL where id_spbl = "+id_spbl+"";
            datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public DataTable CheckExistSPTK(string tensanpham)
        {
            DataTable datatb = new DataTable();
            string query =string.Format("select*from SPBL where tensanpham =N'{0}'",tensanpham);
            datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public bool InsertSPTK(string tensanpham,int giabanle,int soluong)
        {
            string query =string.Format("insert into SPBL (ten_spkm,gia_banle,soluong) values (N'{0}',{1},{2})",tensanpham,giabanle,soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Delete(string tensanpham)
        {
            string query=string.Format("delete from SPBL where ten_spkm = N'{0}'",tensanpham);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Update(string tensanpham, int gia, int soluong)
        {
            string query = string.Format("update SPBL set gia_banle={1},soluong={2} where ten_spkm =N'{0}'  ", tensanpham, gia, soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateSL(string tensanpham, int soluong)
        {
            string query = string.Format("update SPBL set soluong={1} where ten_spkm =N'{0}'  ", tensanpham, soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetIDSPBL()
        {
            string query = "SELECT*fROM SPBL";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            if (datatb.Rows.Count > 0)
            {
                SPBL spbl = new SPBL(datatb.Rows[0]);
                return spbl.ID_SPBL;
            }
            return -1;
        }
        public bool UpdateSL(int soluong, int id_spbl)
        {
            string query = "UPDATE SPBL SET SOLUONG=" + soluong + " WHERE ID_SPBL = " + id_spbl + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
