using NhaThuocOnline.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Order
{
    public class OrderItemCustomerAddress
    {
        public List<CustomerAddressVm> CustomerAddressVm { get; set; }

        public List<OrderItemVm> OrderItemVm { get; set; }
    }
}
