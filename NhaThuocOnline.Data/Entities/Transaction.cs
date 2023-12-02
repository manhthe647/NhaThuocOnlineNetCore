using NhaThuocOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Entities
{
    public class Transaction
    {
        public  int Id { get; set; }
        public int CustomerID { get; set; }

        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public double Amount { get; set; }
        public DateTime UpdatedAt { get; set;}
        public PaymentStatus Status { get; set; }

    }
}
