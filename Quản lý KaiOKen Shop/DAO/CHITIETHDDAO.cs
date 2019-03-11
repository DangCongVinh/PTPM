using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class CHITIETHDDAO
    {
        private static CHITIETHDDAO instance;

        public static CHITIETHDDAO Instance
        {
            get { if (instance == null) instance = new CHITIETHDDAO(); return instance; }
            private set { instance = value; }
        }
        public CHITIETHDDAO() { }
        
        public bool InsertCTHDByMaxID(int id_hd, string id_giay, int id_spbl,int id_discount,int slspbl)
        {
            string query = string.Format("INSERT INTO CHITIETHOADON (ID_HD,ID_GIAY,ID_SPBL,ID_DISCOUNT,SOLUONGSPBL) VALUES ({0},N'{1}',{2},{3},{4})",id_hd,id_giay,id_spbl,id_discount,slspbl);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable GetCTHDByID_HD(int id_hd)
        {
            string query = "SELECT ID_CTHD, A.ID_HD,E.ID_GIAY,TenLoaiGiay,DISCOUNTLV,GIA,TEN_SPKM,SOLUONGSPBL FROM HOADON A, CHITIETHOADON B, DISCOUNT C, SPBL D, THONGTINGIAY E, Catarogry F WHERE A.ID_HD = B.ID_HD AND B.ID_DISCOUNT = C.ID_DISCOUNT AND B.ID_SPBL = D.ID_SPBL AND E.ID_Giay = B.ID_GIAY AND E.ID_LoaiGiay = F.ID_LoaiGiay AND A.ID_HD = " + id_hd+"";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public DataTable GETSPBL(int id_hd)
        {
            string query = "SELECT Ten_SPKM,SOLUONGSPBL,Gia_banle FROM CHITIETHOADON A, SPBL B WHERE ID_HD="+id_hd+" AND A.ID_SPBL=B.ID_SPBL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
