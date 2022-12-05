using ConsoleApp4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Configuration
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);


            builder.HasMany(x => x.Accounts)
                .WithOne(x => x.Currency)
                .HasForeignKey(x => x.CurrencyId)
                .HasConstraintName("FK_Currancy");
        }
    }
}
