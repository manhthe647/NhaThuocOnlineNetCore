using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public double RegularPrice { get; set; }
        public double DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoShortDescription { get; set; }

        public bool IsPublished { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }



    }
}
