using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Prescription
{
    public class PrescriptionCreateRequest
    {
        public IFormFile ImagePath { get; set; }
        public string CustomerNote { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
    }
}
