using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using University.Models;

namespace University.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department", "department");
            
            builder.Property(x => x.Name)
                .HasMaxLength(150)
                .IsRequired();


            builder.Property(x => x.MaxNumberOfStudents)
                .HasColumnType("int")
                .HasDefaultValue(0)
                  .IsRequired();

            builder.Property(x => x.CurrentAmount)
                .HasColumnType("int")
                .HasDefaultValue(0)
                  .IsRequired();

            builder.Property(x => x.SemesterId);


            builder.HasMany(x => x.Students)
             .WithOne(x => x.Department)
             .HasForeignKey(x => x.DepartmentId)
             .HasConstraintName("FK_Students_Department");


            builder.HasMany(x => x.Teachers)
           .WithOne(x => x.Department)
           .HasForeignKey(x => x.DepartmentId)
           .HasConstraintName("FK_Teachers_Department");
        }

    }
}
