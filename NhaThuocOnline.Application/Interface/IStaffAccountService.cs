using NhaThuocOnline.Application.ViewModels.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Interface
{
    public interface IStaffAccountService
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        //Task<List<CustomerVm>> GetCustomerPaging(GetCustomerPaging request);
        Task<CustomerVm> GetCustomerById(int id);


        Task<bool> Update(CustomerVm request);
        Task<bool> Delete(int id);
    }
}
