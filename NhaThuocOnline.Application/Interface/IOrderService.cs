using NhaThuocOnline.ViewModel.Cart;
using NhaThuocOnline.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Interface
{
    public interface IOrderService
    {
        Task<List<OrderItemVm>> GetProductByCartId(string cartId);

        Task<bool> CreateOrder(OrderCreateRequest request);
        Task<OrderDetailVm> GetOrderById(int orderId);
        Task<List<OrderDetailVm>> GetOrderRecently();
        Task<bool> ChangeStatusOrder(ChangeStatusRequest request);

        Task GetOrderByCustomerId(int customerId);
        Task<bool> UpdateOrder();
        Task<bool> DeleteOrder();

    }
}
