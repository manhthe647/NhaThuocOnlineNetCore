using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Configurations
{
    public class ProductCouponConfiguration : IEntityTypeConfiguration<ProductCoupon>
    {
        public void Configure(EntityTypeBuilder<ProductCoupon> builder)
        {
            builder.ToTable("ProductCoupons");
            builder.HasNoKey();
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.CouponId).IsRequired();


        }
    }
}
