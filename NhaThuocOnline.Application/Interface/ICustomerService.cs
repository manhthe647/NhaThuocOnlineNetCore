using NhaThuocOnline.ViewModel.Common;
using NhaThuocOnline.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Interface
{
    public interface ICustomerService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<List<CustomerVm>> GetCustomerPaging();
        Task<CustomerVm> GetCustomerById(int id);

        Task<bool> Update(int id, CustomerUpdateRequest request);
        Task<bool> SoftDelete(int id);

        Task<bool> CreateCustomerAddress(int id,CustomerAddressCreateRequest request);

        //Task<ApiResult<bool>> CreateCustomerAddress(CustomerAddressCreateRequest request); 

        //Task<ApiResult<bool>> ChangePassword(ChangePasswordRequest request);
    }
}
