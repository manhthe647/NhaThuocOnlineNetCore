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

            if (request.CustomerId != null)
            {
                var assignCart = new Cart()
                {
                    CartId = request.CartId,
                    CustomerId = request.CustomerId ?? -1,
                    CreatedAt = DateTime.Now,
                };
                _dbContext.Carts.Add(assignCart);

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
            var query = (from ci in _dbContext.CartItems
                         join p in _dbContext.Products on ci.ProductId equals p.Id
                         select new { ci,p }).AsQueryable();

            var data = await query.Where(x => x.ci.CartId == cartId).ToListAsync();

       

            var assignedCart = await _dbContext.Carts.Where(x=>x.CartId == cartId).FirstOrDefaultAsync();
            var assignedCartId = assignedCart != null ? Convert.ToInt32(assignedCart.CustomerId) : -1;

            var cartDetails = data.Select(item => new CartItemVm
            {
                Id = item.ci.Id,
                CustomerId= assignedCartId,
                CartId = item.ci.CartId,
                ProductName = item.p.ProductName,
                ProductImagePath = item.p.ImagePath,
                Price= item.p.DiscountPrice,
                Quantity = item.ci.Quantity,
                TotalPrice = item.p.DiscountPrice * item.ci.Quantity ,
            }).ToList();

            return cartDetails;
        }

        public async Task<string> GetCartIdRecently(int customerId)
        {
           var data= await _dbContext.Carts.OrderByDescending(x=>x.CreatedAt).FirstOrDefaultAsync(x=>x.CustomerId == customerId);
            return data.CartId.ToString();
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
