using NhaThuocOnline.ViewModel.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Intergration
{
    public interface ICartApiClient
    {
        Task<bool> CreateCartItem(CartCreateRequest request);

        Task<List<CartItemVm>> GetByCartId(string cartId);
        Task<string> GetCartIdRecently(int customerId);
    }
}
