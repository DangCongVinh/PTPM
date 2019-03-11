using Quản_lý_KaiOKen_Shop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class CatarogryDAO
    {
        private static CatarogryDAO instance;

        internal static CatarogryDAO Instance
        {
            get { if (instance == null) instance = new CatarogryDAO(); return instance; }
            private set { instance = value; }
        }
        private CatarogryDAO(){ }

        public List<Catarogry> LoadLoaiHang()
        {
            List<Catarogry> list = new List<Catarogry>();
            DataTable datatb = new DataTable();
            string query = "select* from catarogry";
            datatb = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in datatb.Rows)
            {
                Catarogry catarogry = new Catarogry(item);
                list.Add(catarogry);
            }
            return list;
        }
        public DataTable LoadLoaiGiay()
        {
            string query = "Select*from catarogry where id_loaigiay<>1002";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public bool InsertLoaiGiay(string tenloaigiay)
        {
            string query = "Insert into catarogry (tenloaigiay) values (N'" + tenloaigiay + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i > 0;
        }
        public bool DeleteLoaiGiay(string tenloaigiay)
        {
            string query = "delete from catarogry where tenloaigiay=N'"+tenloaigiay+"'";
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i > 0;
        }
        public bool UpdateLoaiGiay(string tenloaigiay, int id)
        {
            string query = string.Format("update catarogry set tenloaigiay = N'{0}' where id_loaigiay ={1}",tenloaigiay,id);
            int i = DataProvider.Instance.ExecuteNonQuery(query);
            return i > 0;
        }
        public int GetIDLoaiGiay(string id_giay)
        {
            string query = "select * from catarogry a, ThongTinGiay b where a.id_loaigiay=b.id_loaigiay and id_giay =N'"+id_giay+"' ";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);

            if (datatb.Rows.Count > 0)
            {
                Catarogry catarogry = new Catarogry(datatb.Rows[0]);
                return catarogry.ID_LoaiGiay;
            }
            return -1;
        }
    }
}
