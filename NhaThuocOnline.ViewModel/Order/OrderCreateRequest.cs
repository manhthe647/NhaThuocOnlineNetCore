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

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItemVm { get; set; }
        public int? CouponId { get; set; }


    }

}
