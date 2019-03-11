using Quản_lý_KaiOKen_Shop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class HOADDONDAO
    {
        private static HOADDONDAO instance;

        public static HOADDONDAO Instance
        {
            get { if (instance == null) instance = new HOADDONDAO(); return instance; }
            private set{ instance = value; }
        }
        public HOADDONDAO()
        {

        }
        //public bool InsertHD( string ngaymua, int tongtien, string id_giay)
        //{
        //    string query = string.Format("SET DATEFORMAT DMY insert into hoadon(ngaymua,tongtien,id_giay) values (N'{0}',{1},N'{2}')", ngaymua, tongtien,id_giay);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        public DataTable LoadDSHD(int month)//string ngaymua
        {
            string query = "SELECT ID_HD,NGAYTAO,TONGTIEN,DISPLAYNAME FROM HOADON A, Account B WHERE A.USERNAME = B.UserName AND MONTH(NGAYTAO)="+month+"";//where ngaymua='"+ngaymua+"'
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        //public int GetIDBill(string id_giay)
        //{
        //    string query = "select*from hoadon where id_giay =N'"+ id_giay+"'";
        //    DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
        //    if (datatb.Rows.Count > 0)
        //    {
        //        HOADON bill = new HOADON(datatb.Rows[0]);
        //        return bill.Ma_hoadon;
        //    }
        //    return -1;
        //}
        public bool InsertHD(string ngaytao, int tongtien, string username)
        {
            string query = string.Format("SET DATEFORMAT DMY INSERT INTO HOADON(NGAYTAO,TONGTIEN,USERNAME) VALUES (N'{0}',{1},N'{2}')",ngaytao,tongtien,username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaxIDBill()
        {
            string query = "SELECT * FROM HOADON WHERE ID_HD = (SELECT MAX(ID_HD) FROM HOADON)";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            if (datatb.Rows.Count > 0)
            {
                HOADON bill = new HOADON(datatb.Rows[0]);
                return bill.ID_HD;
            }
            return -1;
        }
        public DataTable DoanhThuThang(int month, int year)
        {
            string query = "SELECT SUM(TONGTIEN) FROM HOADON WHERE MONTH(NGAYTAO) ="+month+" AND YEAR(NGAYTAO)="+year+"";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public DataTable DoanhThuDay(int month, int day, int year)
        {
            string query = "SELECT SUM(TONGTIEN) FROM HOADON WHERE MONTH(NGAYTAO) ="+month+" AND DAY(NGAYTAO)="+day+ " AND YEAR(NGAYTAO)=" + year + "";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public DataTable MaxLG(int month, int year)
        {
            string query = string.Format("select  count(id_cthd),TenLoaiGiay from HOADON A, CHITIETHOADON B, Catarogry C, Account D, THONGTINGIAY E where A.ID_HD = B.ID_HD AND A.USERNAME = D.UserName AND E.ID_Giay = B.ID_GIAY AND E.ID_LoaiGiay = C.ID_LoaiGiay and MONTH(NGAYTAO) = {0} and YEAR(NGAYTAO) ={1} group by TenLoaiGiay order by count(ID_CTHD) DESC", month,year);
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public DataTable GetReportBill(int id_hd)
        {
            string query = "SELECT A.ID_HD, NGAYTAO, A.USERNAME, B.ID_GIAY,TENLOAIGIAY, GIA, DISCOUNT FROM HOADON A, CHITIETHOADON B, Catarogry C , Account D, THONGTINGIAY E WHERE A.ID_HD = B.ID_HD AND A.USERNAME = D.UserName AND E.ID_Giay = B.ID_GIAY AND E.ID_LoaiGiay = C.ID_LoaiGiay AND A.ID_HD ="+id_hd+"";
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }

        public DataTable ThongKeSLBan(int monht1, int month2)
        {
            string query = string.Format("SELECT COUNT(B.ID_CTHD) AS [SOLUONG],NGAYTAO FROM HOADON A, CHITIETHOADON B WHERE A.ID_HD = B.ID_HD AND NGAYTAO > '{0}/1/2018' AND NGAYTAO<'{1}/1/2018' GROUP BY NGAYTAO",monht1,month2);
            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
    }

}
