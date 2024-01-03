using NhaThuocOnline.Data.Entities;
using NhaThuocOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Order
{
    public class OrderCreateRequest
    {
        public int? CustomerId { get; set; }


        public OrderDetail OrderDetails { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        //public int? CouponId { get; set; }


    }

}
