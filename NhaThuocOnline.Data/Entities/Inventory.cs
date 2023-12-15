using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public int BatchId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
