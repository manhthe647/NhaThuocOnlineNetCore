using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Entities
{
    public class CustomerAddress
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AddressLine1{ get; set; }
        public string AddressLine2 { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string City { get; set; }
        public string District { get; set; }


    }
}
