using NhaThuocOnline.ViewModel.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace NhaThuocOnline.Application.Interface
    {
        public interface ICartService
        {
        Task<string> CreateCartItem(CartCreateRequest request);
        //Task<int> UpdateQuantity(CartUpdateQuantityRequest request);

        Task<List<CartItemVm>> GetByCartId(string cartId);
        //Task<bool> DeleteItem(int productId);
        //Task<bool> ClearCart(int cartId);
        }
    }
