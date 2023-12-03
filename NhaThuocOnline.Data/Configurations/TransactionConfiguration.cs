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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.CustomerID).IsRequired();

            builder.Property(x => x.TransactionDate).IsRequired();
            builder.Property(x => x.TransactionType).IsRequired();
            builder.Property(x => x.Amount).IsRequired();

            builder.Property(x => x.UpdatedAt).IsRequired();
            builder.Property(x => x.Status).IsRequired();


        }
    }
}
