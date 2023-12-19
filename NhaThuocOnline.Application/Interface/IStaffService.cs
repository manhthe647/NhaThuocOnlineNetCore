using NhaThuocOnline.Application.ViewModels.Customer;
using NhaThuocOnline.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Interface
{
    public interface IStaffService
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<List<CustomerVm>> GetStaffPaging();
        Task<CustomerVm> GetStaffById(int id);
        Task<bool> RoleAssign(int id, CustomerAddressCreateRequest request);

        //Task<bool> Update(int id, CustomerUpdateRequest request);
        //Task<bool> SoftDelete(int id);

    }
}
