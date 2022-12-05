using ConsoleApp4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Configuration
{
    public class TransationConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(x => x.Amount)
                 .HasColumnType("decimal(18, 2)");
            builder.Property(x => x.Purpose)
                .IsRequired()
                .HasMaxLength(255);
           
        }
    }
}
