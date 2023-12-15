using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Product
{
    public class ProductCreateRequest
    {
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public double RegularPrice { get; set; }
        public double DiscountPrice { get; set; }
        public string Description { get; set; }

        public string Brand { get; set; }
        public string Packaging { get; set; }
        public string Origin { get; set; }
        public string Manufacturer { get; set; }
        public string ProductionLocation { get; set; }
        public string Ingredients { get; set; }

        public IFormFile ImagePath { get; set; }
        public string SeoTitle { get; set; }

        public bool IsPrescriptionRequired { get; set; }
    }
}
