using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University
{
    
    public class BalanceConfiguration : IEntityTypeConfiguration<Balance>
    {
        
        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder.ToTable("Balance", "balance");
            
            builder.Property(x => x.Amount).HasColumnType("decimal(18,2)").HasDefaultValue(0);

            builder.Property(x => x.SemesterId);
            builder.Property(x => x.StudentId); 

            builder.Property(x => x.Debth).HasColumnType("decimal(18,2)");


        }
    }
}