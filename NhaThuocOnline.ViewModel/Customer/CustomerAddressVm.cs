using NhaThuocOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Customer
{
    public class CustomerAddressVm
    {
        public int CustomerId {  get; set; }
        public List<CustomerAddress> Addresses { get; set; }
    }
}
