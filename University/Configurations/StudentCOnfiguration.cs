using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student", "student");
      
            builder.Property(x => x.FirstName)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.LastName)
             .HasMaxLength(200)
             .IsRequired();

            builder.Property(x => x.PersonalId)
              .HasMaxLength(11)
              .IsRequired();

            builder.Property(x => x.StartYear)
                   .HasColumnType("int")
                   .IsRequired();


            builder.Property(x => x.DepartmentId);

            builder.HasOne(b => b.Address)
                .WithOne(b => b.Student)
                .HasForeignKey<Student>(b => b.AddressId);



            builder.Property(x => x.SemesterId);

            builder.HasMany(x => x.StudentSubject)
            .WithOne(x => x.Student)
            .HasForeignKey(x => x.StudentId)
            .HasConstraintName("FK_StudentSubject_Student");




        }
    }
}
