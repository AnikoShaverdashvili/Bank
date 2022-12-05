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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Name).HasMaxLength(100);


            builder.HasMany(x => x.Account)
               .WithOne(x => x.Category)
               .HasForeignKey(x => x.CategoryId)
               .HasConstraintName("FK_Categoty");
        }
    }
}
