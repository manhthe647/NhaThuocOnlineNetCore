using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace NhaThuocOnline.Data.Entities
{
    public class AppStaffRole: IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
