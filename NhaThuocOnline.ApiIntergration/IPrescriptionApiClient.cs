using NhaThuocOnline.ViewModel.Coupon;
using NhaThuocOnline.ViewModel.Prescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ApiIntergration
{
    public interface IPrescriptionApiClient
    {
        Task<bool> Create(PrescriptionCreateRequest request);
        Task<List<PrescriptionVm>> GetAll();
    }
}
