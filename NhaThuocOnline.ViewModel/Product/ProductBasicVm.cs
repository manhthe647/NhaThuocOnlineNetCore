using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Product
{
    public class ProductBasicVm
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public double RegularPrice { get; set; }
        public double DiscountPrice { get; set; }
        public bool isPrescriptionRequired { get; set; }
    }
}
