using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class KHACHHANG
    {
        public KHACHHANG(string sdtkm)
        {
            this.SDTKM = sdtkm;
            
        }

        public KHACHHANG(DataRow row)
        {
            this.SDTKM = row["sdtkm"].ToString();
            
        }

        private string sDTKM;
        private int dISCOUNT;

        public string SDTKM { get => sDTKM; set => sDTKM = value; }
        
    }
}
