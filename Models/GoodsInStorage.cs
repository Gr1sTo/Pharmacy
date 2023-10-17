using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class GoodsInStorage
    {
        public int ID { get; set; }
        public int Article { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Availability { get; set; }
        public int StorageID { get; set; }
    }
}
