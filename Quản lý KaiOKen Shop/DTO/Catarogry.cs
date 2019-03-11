using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class Catarogry
    {
        public Catarogry(int id, string tenloaigiay)
        {
            this.ID_LoaiGiay = id;
            this.Tenloaigiay = tenloaigiay;
        }
        public Catarogry(DataRow row)
        {
            this.ID_LoaiGiay = (int)row["ID_LoaiGiay"];
            this.Tenloaigiay = row["tenloaigiay"].ToString();
        }
        private string tenloaigiay;

        private int iD_LoaiGiay;
    
        public int ID_LoaiGiay
        {
             get { return iD_LoaiGiay; }
             set { iD_LoaiGiay = value;}
        }
        public string Tenloaigiay { get => tenloaigiay; set => tenloaigiay = value; }
    }
}
