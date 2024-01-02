using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Cart
{
    public class CartUpdateQuantityRequest
    {

        public int? CustomerId { get; set; }

        public string CartId { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
