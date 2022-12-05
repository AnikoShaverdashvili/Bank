using ConsoleApp4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x=>x.Balance)
             .HasColumnType("decimal(18,2)")
            .HasDefaultValue(0);

            builder.Property(x => x.Iban)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.ExpirationDate)
                .IsRequired();

        }
    }
}
