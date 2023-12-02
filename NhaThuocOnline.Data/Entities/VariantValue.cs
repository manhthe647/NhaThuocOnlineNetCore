using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Entities
{
    public class VariantValue
    {
        public int Id { get; set; }
        public int VarientId { get; set; }
        public double OriginPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
}
