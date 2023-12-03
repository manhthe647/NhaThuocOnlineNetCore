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
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {

            builder.ToTable("Coupons");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Code).IsRequired();

            builder.Property(x => x.CouponDescription).HasMaxLength(200).IsRequired();
            builder.Property(x=>x.TimesUsed).IsRequired();
            builder.Property(x=>x.MaxUsage).IsRequired();

            builder.Property(x => x.CouponStartDate).IsRequired();
            builder.Property(x => x.CouponEndDate).IsRequired();

            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.UpdatedBy).IsRequired();

        }
    }
}
