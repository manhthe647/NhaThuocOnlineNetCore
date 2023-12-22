using NhaThuocOnline.ViewModel.Cart;
using NhaThuocOnline.ViewModel.Common;
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

        Task<List<CartItemVm>> GetByCartId(string cartId);
        Task<bool> UpdateQuantity(CartUpdateQuantityRequest request);
        Task<bool> DeleteItem(int id);

        //Task<bool> ClearCart(int cartId);
    }
    }
