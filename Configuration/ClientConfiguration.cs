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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        void IEntityTypeConfiguration<Client>.Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(x=>x.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x=>x.LastName)
                .IsRequired()
                .HasMaxLength(50); 
            builder.Property(x=>x.PersonalId)
                .IsRequired()   
                .HasMaxLength(50);
            builder.HasMany(x => x.Accounts)
                .WithOne(x => x.Client)
                .HasForeignKey(x => x.ClientId).HasConstraintName("FK_Client_Accounts");
        }
    }
}
