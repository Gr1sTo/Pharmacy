using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Bill
    {
        public int ID { get; set; }
        public int PharmacistID { get; set; }
        public int DiscountCardID { get; set; }
        public decimal FinalPrice { get; set; }
        public string TypeOfPayment { get; set; }
        public DateTime DateOfBuy { get; set; }
        public string Place { get; set; }
    }
}
