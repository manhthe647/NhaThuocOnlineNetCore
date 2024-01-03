using NhaThuocOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Order
{
    public class ChangeStatusRequest
    {
        public int OrderDetailsId { get; set; }
        public OrderStatus Status { get; set; }
    }
}
