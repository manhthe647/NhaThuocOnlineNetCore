using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Data.EF;
using NhaThuocOnline.Data.Entities;
using NhaThuocOnline.ViewModel.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Service
{
    public class CartService : ICartService
    {
        private readonly NhaThuocOnlineDbContext _dbContext;
        public CartService(NhaThuocOnlineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> CreateCartItem(CartCreateRequest request)
        {
            var existingProductInCartItem = await _dbContext.CartItems.FirstOrDefaultAsync(x => x.CartId == request.CartId && x.ProductId == request.ProductId);

            if (existingProductInCartItem != null)
            {
                existingProductInCartItem.Quantity += request.Quantity;
                await _dbContext.SaveChangesAsync();
                return existingProductInCartItem.CartId;
            }
        
                var newCartItem = new CartItem
                {
                    CartId = request.CartId,
                    ProductId = request.ProductId,
                    Quantity = request.Quantity
                };

                _dbContext.CartItems.Add(newCartItem);
                await _dbContext.SaveChangesAsync();
                return newCartItem.CartId;
            
        }

        public async Task<bool> DeleteItem(int id)
        {
            var cartItem= await _dbContext.CartItems.FirstOrDefaultAsync(x => x.Id == id);
            if(cartItem != null)
            {
                _dbContext.CartItems.Remove(cartItem);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<CartItemVm>> GetByCartId (string cartId)
        {
            var data = await _dbContext.CartItems.Where(x => x.CartId == cartId).ToListAsync();

            var cartDetails = data.Select(item => new CartItemVm
            {
                Id = item.Id,
                CartId = item.CartId,
                ProductId = item.ProductId,
                Quantity = item.Quantity
            }).ToList();

            return cartDetails;
        }

        public  async Task<bool> UpdateQuantity(CartUpdateQuantityRequest request)
        {
            var existingProductInCartItem = await _dbContext.CartItems.FirstOrDefaultAsync(x => x.CartId == request.CartId && x.ProductId == request.ProductId);
            if (existingProductInCartItem == null)
            {
                return false;
            }
            existingProductInCartItem.Quantity = request.Quantity;
            await _dbContext.SaveChangesAsync();
            return true;
            
        }
    }
}
