using NhaThuocOnline.ViewModel.Category;
using NhaThuocOnline.ViewModel.Prescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Application.Interface
{
    //đơn thuốc
    public interface IPrescriptionService
    {
        Task<bool> Create(PrescriptionCreateRequest request);
        Task<List<PrescriptionVm>> GetAll();
    }
}
