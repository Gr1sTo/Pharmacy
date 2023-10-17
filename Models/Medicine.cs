using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Medicine
    {
        public int Article { get; set; }
        public string ActiveSubstance { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string MethodOfAdministration { get; set; }
        public string ReleaseForm { get; set; }
        public int CountInPack { get; set; }
        public bool RecipeNeed { get; set; }
        public int Temperature { get; set; }
        public string Packing { get; set; }
        public int ProducerCode { get; set; }
    }
}
