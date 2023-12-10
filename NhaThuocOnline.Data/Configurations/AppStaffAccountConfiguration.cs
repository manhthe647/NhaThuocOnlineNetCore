using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NhaThuocOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Configurations
{
    public class AppStaffAccountConfiguration : IEntityTypeConfiguration<AppStaffAccount>
    {
        public void Configure(EntityTypeBuilder<AppStaffAccount> builder)
        {
            builder.ToTable("AppStaffAccounts");
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
        }
    }
}
