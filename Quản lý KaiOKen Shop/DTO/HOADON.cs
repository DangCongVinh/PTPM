using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class HOADON
    {
        public HOADON(int iD_HD, DateTime ngaytao, int tongtien, string username)
        {
            this.ID_HD = iD_HD;
            this.Ngaytao= ngaytao;
            this.Tongtien = tongtien;
            this.Username = username;
        }
        public HOADON(DataRow row)
        {
            this.ID_HD =(int)row["iD_HD"];
            this.Ngaytao = (DateTime)row["ngaytao"];
            this.Tongtien = Convert.ToInt32(row["tongtien"]);
            this.Username = row["username"].ToString();
            
        }

        private int iD_HD;
        private DateTime ngaytao;
        private int tongtien;
        private string username;
        


        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Username { get => username; set => username = value; }
        public int ID_HD { get => iD_HD; set => iD_HD = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        
    }
}
