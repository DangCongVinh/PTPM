using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class CHITIETHOADON
    {
        public CHITIETHOADON( int id_chitietHD,string id_giay,int id_hd, int id_spbl, int id_discount,int slspbl)
        {
            this.Id_chitietHD = id_chitietHD;
            this.Id_giay = id_giay;
            this.ID_HD = id_hd;
            this.ID_SPBL = id_spbl;
            this.Id_discount = id_discount;
            this.Soluongspbl = slspbl;
        }
        public CHITIETHOADON(DataRow row)
        {
            this.Id_chitietHD = (int)row["id_chitietHD"];
            this.Id_giay =row["id_giay"].ToString();
            this.ID_HD = (int)row["id_hd"];
            this.ID_SPBL = (int)row["id_spbl"];
            this.Id_discount = (int)row["id_discount"];
            this.Soluongspbl = (int)row["slspbl"];
        }

        private int id_chitietHD;
        private string id_giay;
        private int iD_HD;
        private int iD_SPBL;
        private int id_discount;
        private int soluongspbl;

        public int Id_chitietHD { get => id_chitietHD; set => id_chitietHD = value; }
        public string Id_giay { get => id_giay; set => id_giay = value; }
        public int ID_HD { get => iD_HD; set => iD_HD = value; }
        public int ID_SPBL { get => iD_SPBL; set => iD_SPBL = value; }
        public int Id_discount { get => id_discount; set => id_discount = value; }
        public int Soluongspbl { get => soluongspbl; set => soluongspbl = value; }
    }
}
