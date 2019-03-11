using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class CHITIETHD
    {
        public CHITIETHD(double discount, int id_chitietHD,string id_giay,int ma_hoadon)
        {
            this.Discount = discount;
            this.Id_chitietHD = id_chitietHD;
            this.Id_giay = id_giay;
            this.Ma_hoadon = ma_hoadon;
        }
        public CHITIETHD(DataRow row)
        {
            this.Discount =Convert.ToDouble(row["discount"]);
            this.Id_chitietHD = (int)row["id_chitietHD"];
            this.Id_giay = row["id_giay"].ToString();
            this.Ma_hoadon = (int)row["ma_hoadon"];
        }

        private double discount;
        private int id_chitietHD;
        private string id_giay;
        private int ma_hoadon;

        public int Id_chitietHD { get => id_chitietHD; set => id_chitietHD = value; }
        public int Ma_hoadon { get => ma_hoadon; set => ma_hoadon = value; }
        public string Id_giay { get => id_giay; set => id_giay = value; }
        public double Discount { get => discount; set => discount = value; }
    }
}
