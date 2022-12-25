using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using University.Models;
using System.Net;

namespace V2_Final500W.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {

     
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address", "address");
            
            builder.Property(x => x.Address1).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Address2).HasMaxLength(200);


            builder.HasOne(b => b.Student)
                .WithOne(b => b.Address)
                .HasForeignKey<Address>(b => b.StudentId);


            builder.HasOne(b => b.Teacher)
              .WithOne(b => b.Address)
              .HasForeignKey<Address>(b => b.StudentId);

        }
    }
}
