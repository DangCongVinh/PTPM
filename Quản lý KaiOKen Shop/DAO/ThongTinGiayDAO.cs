using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quản_lý_KaiOKen_Shop.DAO;
using System.Data;

namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class THONGTINGIAYDAO
    {
        private static THONGTINGIAYDAO instance;

        internal static THONGTINGIAYDAO Instance
        {
            get { if (instance == null) instance = new THONGTINGIAYDAO(); return instance; }
            private set { instance = value; }
        }

        public THONGTINGIAYDAO() { }

        public bool checkMaHang(string mahang)
        {
            string query = "select*from THONGTINGIAY where ID_Giay= '" + mahang+"' ";

            DataTable datatb = DataProvider.Instance.ExecuteQuery(query);

            return datatb.Rows.Count > 0;
        }
        public DataTable gia(string mahang)
        {
            DataTable datatb = new DataTable();
            string query = "select ID_Giay,TenSanPham,tenloaigiay as [Ten Loại Giay],Gia from THONGTINGIAY a, Catarogry b where ID_Giay= '" + mahang+"' and a.id_loaigiay=b.id_loaigiay";
            datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }
        public DataTable TatCaGiay()
        {
            DataTable datatb = new DataTable();
            string query = "select ID_Giay,TenSanPham,Gia,tenloaigiay from THONGTINGIAY a, Catarogry b where a.id_loaigiay=b.id_loaigiay and status = 0";
            datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }

        public DataTable SPDaBan()
        {//xem các sản phẩm đã bán
            DataTable datatb = new DataTable();
            string query = "SELECT B.ID_GIAY,TenSanPham,TenLoaiGiay,CONVERT(nvarchar(10),NGAYTAO,103),Gia FROM HOADON A, CHITIETHOADON B, THONGTINGIAY C, Catarogry D WHERE A.ID_HD = B.ID_HD AND B.ID_GIAY = C.ID_Giay AND C.ID_LoaiGiay = D.ID_LoaiGiay AND Status = 1 AND b.ID_Giay <> 'Không'";
            datatb = DataProvider.Instance.ExecuteQuery(query);
            return datatb;
        }

        public bool InsertGiay(string mahang, string tensanpham, int gia, int loaigiay)
        {
            string query = string.Format("insert into THONGTINGIAY(ID_Giay, TenSanPham, Gia, ID_LoaiGiay,status) values(N'{0}',N'{1}',{2},{3},0)", mahang, tensanpham, gia, loaigiay);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteGiay(string mahang)
        {
            string query = string.Format("delete from THONGTINGIAY where ID_Giay = N'{0}'",mahang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0 ;
        }
        public bool UpdateGiay(string mahang, string tensanpham, int gia, int loaigiay)
        {
            // id_giay=N'{0}',
            string query = string.Format("UPDATE THONGTINGIAY set TenSanPham=N'{1}', Gia={2}, ID_LoaiGiay={3} WHERE ID_GIAY=N'{0}'", mahang, tensanpham, gia, loaigiay);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateStatus(string mahang)
        {
            // id_giay=N'{0}',
            string query = string.Format("UPDATE THONGTINGIAY SET status = 1 where id_giay=N'{0}' ",mahang );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int SoluongGiayTrongKho()
        {
            object soluong=0;
            string query = "select count (*)from THONGTINGIAY where status=0";
            soluong = DataProvider.Instance.ExecuteScalar(query);
            return (int)soluong;
        }
        //public string GetID_Giay()
        //{
        //    string query = "select *from ThongTinGiay where"
        //}
    }
}
