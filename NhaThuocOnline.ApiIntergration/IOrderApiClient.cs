using NhaThuocOnline.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Intergration
{
    public interface IOrderApiClient
    {
        Task<List<OrderItemVm>> GetProductByCartId(string cartId);

    }
}
