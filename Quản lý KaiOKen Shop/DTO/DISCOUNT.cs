using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_KaiOKen_Shop.DTO
{
    public class DISCOUNT
    {
        public DISCOUNT(double discount, int id_discount)
        {
            
            this.discount = Discount;
            this.ID_DISCOUNT = id_discount;
        }

        public DISCOUNT(DataRow row)
        {
            this.discount =Convert.ToDouble(row["Discount"]);
            this.ID_DISCOUNT = (int)row["id_discount"];
        }
        private double discount;
        private int iD_DISCOUNT;

        public double Discount { get => discount; set => discount = value; }
        public int ID_DISCOUNT { get => iD_DISCOUNT; set => iD_DISCOUNT = value; }
    }
}
