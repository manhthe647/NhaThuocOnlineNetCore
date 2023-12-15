using NhaThuocOnline.Application.ViewModels.Customer;
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
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<List<CustomerVm>> GetCustomerPaging();
        Task<CustomerVm> GetCustomerById(int id);

        //Task<bool> ChangePassword(ChangePasswordRequest request);
        Task<bool> Update(int id, CustomerUpdateRequest request);
        Task<bool> SoftDelete(int id);
    }
}
