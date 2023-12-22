using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Interface
{
    public interface IOrderService
    {
        Task<int> CreateOrder();
        Task GetOrderRecently(int orderId);

        Task GetOrderById(int orderId);
        Task GetOrderByCustomerId(int customerId);
        Task<bool> UpdateOrder();
        Task<bool> DeleteOrder();

    }
}
