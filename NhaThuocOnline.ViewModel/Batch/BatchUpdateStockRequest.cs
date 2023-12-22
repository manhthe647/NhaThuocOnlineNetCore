using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Batch
{
    public class BatchUpdateStockRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public int Stock { get; set; }
      
    }
}
