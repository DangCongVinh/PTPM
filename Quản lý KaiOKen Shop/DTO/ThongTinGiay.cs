using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class THONGTINGIAY
    {
        public THONGTINGIAY(string id_giay, string tensanpham, int gia, int id_loaigiay, int status)
        {
            this.Id_Giay = id_Giay;
            this.TenSanPham = tenSanPham;
            this.Gia = gia;
            this.Id_LoaiGiay = id_loaigiay;
            this.Status = status;
        }
        public THONGTINGIAY(DataRow row)
        {
            this.Id_Giay = row["id_Giay"].ToString();
            this.TenSanPham = row["tenSanPham"].ToString();
            this.Gia = (int)row["gia"];
            this.Id_LoaiGiay = (int)row["id_loaigiay"];
            this.Status =(int)row["status"];
        }

        private string id_Giay;
        private string tenSanPham;
        private int gia;
        private int id_LoaiGiay;
        private int status;

        public string Id_Giay { get => id_Giay; set => id_Giay = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Id_LoaiGiay { get => id_LoaiGiay; set => id_LoaiGiay = value; }
        public int Status { get => status; set => status = value; }
    }
}
