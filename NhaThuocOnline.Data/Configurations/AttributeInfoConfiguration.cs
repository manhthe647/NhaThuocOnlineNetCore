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
    public class AttributeInfoConfiguration : IEntityTypeConfiguration<AttributeInfo>
    {
        public void Configure(EntityTypeBuilder<AttributeInfo> builder)
        {
            builder.ToTable("AttributeInfo");
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.AttributeName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.AttributeValue).HasMaxLength(200).IsRequired();


            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.UpdatedBy).IsRequired();

        }
    }
}
