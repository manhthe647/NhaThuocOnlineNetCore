﻿using NhaThuocOnline.ViewModel.Common;
using NhaThuocOnline.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ApiIntergration
{
    public interface ICustomerApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<List<CustomerVm>> GetCustomerPaging();
        Task<List<CustomerAddressVm>> GetCustomerAddresses(int customerId);

        Task<CustomerVm> GetCustomerById(int id);

        //Task<bool> ChangePassword(ChangePasswordRequest request);
        Task<bool> Update(int id,CustomerUpdateRequest request);
        Task<bool> SoftDelete(int id);
    }
}
