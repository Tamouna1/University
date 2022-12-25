using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Models;

namespace University.Configurations
{
    public class SemesterConfiguration : IEntityTypeConfiguration<Semester>
    {
       
        public void Configure(EntityTypeBuilder<Semester> builder)
        {
            builder.ToTable("Semester", "semester");
           
            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();


            builder.Property(x => x.AvaliableGPA)
                .HasColumnType("int")
                .HasDefaultValue(0)
                  .IsRequired();

            builder.Property(x => x.Year)
          .HasColumnType("int");


            builder.Property(x => x.StartDate)
                  .HasColumnType("datetime2")
                   .HasPrecision(0);

            builder.Property(x => x.EndDate)
                 .HasColumnType("datetime2")
                  .HasPrecision(0);


            builder.HasMany(x => x.Schedules)
                .WithOne(x => x.Semester)
                .HasForeignKey(x => x.SemesterId)
                .HasConstraintName("FK_Schedules_Semester");

            builder.HasMany(x => x.Departments)
              .WithOne(x => x.Semester)
              .HasForeignKey(x => x.SemesterId)
              .HasConstraintName("FK_Departments_Semester");

            builder.HasMany(x => x.Students)
                .WithOne(x => x.Semester)
                .HasForeignKey(x => x.SemesterId)
                .HasConstraintName("FK_Students_Semester");

        }
    }
}
