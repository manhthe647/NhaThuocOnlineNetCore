using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Cart
{
    public class CartItemVm
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }

        public string CartId { get; set; }

        public string ProductName { get; set; }
        public string ProductImagePath { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

    }
}
