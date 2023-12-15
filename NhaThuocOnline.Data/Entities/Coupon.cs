using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Entities
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string CouponDescription{ get; set; }
        public int TimesUsed { get; set; }
        public int MaxUsage { get; set; }
        public DateTime CouponStartDate { get; set; }
        public DateTime CouponEndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
   



    }
}
