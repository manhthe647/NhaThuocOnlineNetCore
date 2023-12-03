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
    public class VarientConfiguration : IEntityTypeConfiguration<Variant>
    {
        public void Configure(EntityTypeBuilder<Variant> builder)
        {
            builder.ToTable("Varients");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
       
            builder.Property(x => x.AttributeId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();
        }
    }
}
