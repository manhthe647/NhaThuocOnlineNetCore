using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Common
{
    public class SearchParams
    {
        public int? Keyword { get; set; }
        public int? OrderBy {  get; set; }
        public double? FromPrice { get; set; }
        public double? ToPrice { get; set; }

    }
}
