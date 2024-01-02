using Azure.Core;
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

        public Task<bool> CreateOrder(OrderCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangeStatusOrder(ChangeStatusRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<OrderVm> GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderVm>> GetOrderRecently()
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
