using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class SanPhamTangKemDAO
    {
        private static SanPhamTangKemDAO instance;

        internal static SanPhamTangKemDAO Instance
        {
            get { if (instance == null) instance = new SanPhamTangKemDAO(); return instance; }
            private set { instance = value; }
        }
        private SanPhamTangKemDAO() { }

        public DataTable LoadSPTK()
        {
            DataTable datatb = new DataTable();
            string query = "select*from SanPhamKhuyenMai";
            datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public DataTable CheckExistSPTK(string tensanpham)
        {
            DataTable datatb = new DataTable();
            string query =string.Format("select*from SanPhamKhuyenMai where tensanpham =N'{0}'",tensanpham);
            datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public bool InsertSPTK(string tensanpham,int giabanle,int soluong)
        {
            string query =string.Format("insert into sanphamkhuyenmai (ten_spkm,gia_banle,soluong) values (N'{0}',{1},{2})",tensanpham,giabanle,soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Delete(string tensanpham)
        {
            string query=string.Format("delete from sanphamkhuyenmai where ten_spkm = N'{0}'",tensanpham);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Update(string tensanpham, int gia, int soluong)
        {
            string query = string.Format("update sanphamkhuyenmai set gia_banle={1},soluong={2} where ten_spkm =N'{0}'  ", tensanpham, gia, soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateSL(string tensanpham, int soluong)
        {
            string query = string.Format("update sanphamkhuyenmai set soluong={1} where ten_spkm =N'{0}'  ", tensanpham, soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
