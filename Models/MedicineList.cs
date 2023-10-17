using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class MedicineList
    {
        public int ID { get; set; }
        public int MedArticle { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int BillID { get; set; }
    }
}
