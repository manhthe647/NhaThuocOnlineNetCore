using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Order
{
    public class OrderCreateRequest
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }

        public string CustomerAddress { get; set; }

        public string ProductName { get; set; }
        public string ProductImagePath { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }

}
