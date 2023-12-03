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
    public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.ToTable("CustomerAddresses");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CustomerId).IsRequired();

            builder.Property(x => x.AddressLine1).HasMaxLength(200).IsRequired();
            builder.Property(x => x.AddressLine2).HasMaxLength(200).IsRequired();


            builder.Property(x => x.ReceiverName).IsRequired();
            builder.Property(x => x.ReceiverPhone).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.District).IsRequired();
          

        }
    }
}
