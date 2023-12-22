﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Batch
{
    public class BatchCreateRequest
    {
        public int ProductId { get; set; }
        public double OriginPrice { get; set; }
        public int Quantity { get; set; }

        public int Stock { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
