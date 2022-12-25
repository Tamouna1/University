using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Models;

namespace University
{
   
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {

       
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {

            builder.ToTable("Teacher", "teacher");
            
            builder.Property(x => x.FirstName)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.LastName)
             .HasMaxLength(200)
             .IsRequired();

            builder.Property(x => x.PersonalId)
              .HasMaxLength(11)
              .IsRequired();

            builder.Property(x => x.DepartmentId);

            builder.HasOne(b => b.Address)
              .WithOne(b => b.Teacher)
              .HasForeignKey<Teacher>(b => b.AddressId);

            builder.HasOne(x => x.Subject)
         .WithMany(x => x.Teachers)
         .HasForeignKey(x => x.SubjectId)
         .HasConstraintName("FK_Teachers_Subject");
        }
    }
}
