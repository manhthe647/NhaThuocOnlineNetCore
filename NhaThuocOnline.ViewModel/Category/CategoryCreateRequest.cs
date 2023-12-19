using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Category
{
    public class CategoryCreateRequest
    {
        public int ParentId { get; set; }

        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        //public IFormFile ImagePath {get; set;}
        public string ImagePath { get; set; }
     
    }
}
