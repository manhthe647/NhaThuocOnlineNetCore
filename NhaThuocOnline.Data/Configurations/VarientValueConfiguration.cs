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
    public class VarientValueConfiguration : IEntityTypeConfiguration<VariantValue>
    {
        public void Configure(EntityTypeBuilder<VariantValue> builder)
        {
            builder.ToTable("VariantValues");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.VarientId).IsRequired();
            builder.Property(x => x.OriginPrice).IsRequired();


            builder.Property(x => x.ManufacturingDate).IsRequired();
            builder.Property(x => x.ExpireDate).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.UpdatedBy).IsRequired();
        }
    }
}
