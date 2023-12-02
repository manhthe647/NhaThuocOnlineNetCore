using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Data.Configurations;
using NhaThuocOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.EF
{
    public class NhaThuocOnlineDbContext : DbContext
    {
        public NhaThuocOnlineDbContext(DbContextOptions options) : base(options)
        { 

        }

        public DbSet<Banner> Banners; 
        


    }
}
