﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ProductName).HasMaxLength(200).IsRequired();
            builder.HasIndex(x => x.ProductName);

            builder.Property(x => x.SKU).IsRequired();

            builder.Property(x => x.RegularPrice).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired();

            builder.Property(x => x.SeoTitle).HasMaxLength(200);
            builder.Property(x => x.SeoAlias).HasMaxLength(200);
            //builder.Property(x => x.SeoShortDescription).HasMaxLength(200);


            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();
        

        }
    }
}
