using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class SPBL
    {
        public SPBL(int id_spbl, string ten_spbl, int gia_banle, int soluong)
        {
            this.ID_SPBL = id_spbl;
            this.Ten_SPBL = ten_spbl;
            this.Gia_banle = gia_banle;
            this.SoLuong = soluong;
        }

        public SPBL(DataRow row)
        {
            this.ID_SPBL =(int)row["id_spbl"];
            this.Ten_SPBL = row["ten_spbl"].ToString();
            this.Gia_banle = (int)row["gia_banle"];
            this.SoLuong = (int)row["soluong"];
        }

        private int iD_SPBL;
        private string ten_SPBL;
        private int gia_banle;
        private int soLuong;

        public int ID_SPBL { get => iD_SPBL; set => iD_SPBL = value; }
        public string Ten_SPBL { get => ten_SPBL; set => ten_SPBL = value; }
        public int Gia_banle { get => gia_banle; set => gia_banle = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
