using Azure.Core;
using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Data.EF;
using NhaThuocOnline.Data.Entities;
using NhaThuocOnline.ViewModel.Cart;
using NhaThuocOnline.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Service
{
    public class OrderService : IOrderService
    {
        private readonly NhaThuocOnlineDbContext _dbContext;

        public OrderService(NhaThuocOnlineDbContext dbContext) { 
            _dbContext = dbContext; 
        }


        public async Task<List<OrderItemVm>> GetProductByCartId(string cartId)
        { 
            var productInCart = await (from ci in _dbContext.CartItems
                               join p in _dbContext.Products on ci.ProductId equals p.Id
                               select new { ci, p }).Where(x => x.ci.CartId == cartId).ToListAsync();



            var orderItems = productInCart.Select(x=> new OrderItemVm
            {
                ProductName = x.p.ProductName,
                ProductImagePath = x.p.ImagePath,
                Price = x.p.DiscountPrice,
                Quantity = x.ci.Quantity,
                TotalPrice = x.p.DiscountPrice * x.ci.Quantity,
            }).ToList();
            return orderItems;
        }

        public async Task<bool> CreateOrder(OrderCreateRequest request)
        {
            
            var newOrder= new OrderCreateRequest()
            {

            };
            return true;

        }

        public Task<bool> ChangeStatusOrder(ChangeStatusRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailVm> GetOrderById(int orderId)
        {
            var query = (from oi in _dbContext.OrderItems
                         join o in _dbContext.Orders on oi.OrderId equals o.Id
                         join c in _dbContext.Customers on o.CustomerId equals c.Id
                         join ca in _dbContext.CustomerAddresses on c.Id equals ca.CustomerId
                         select new { oi, o, c, ca }).AsQueryable();

            throw new NotImplementedException();
        }

        public Task<List<OrderDetailVm>> GetOrderRecently()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOrder()
        {
            throw new NotImplementedException();
        }

        public Task GetOrderByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

       

        public Task<bool> UpdateOrder()
        {
            throw new NotImplementedException();
        }

   
    }
}
