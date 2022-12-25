using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Reflection.Emit;
using University.Models;

namespace University.Configurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
      
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("Schedule", "schedule");
            builder.Property(x => x.Year)
            .HasColumnType("int")
                  .IsRequired();


            builder.Property(x => x.StartTime)
                  .HasColumnType("time(7)")
                   
                   .IsRequired();
            

            builder.Property(x => x.EndTime)
                 .HasColumnType("time(7)")
                  
                  .IsRequired();



            builder.Property(x => x.SemesterId);



            builder.HasMany(x => x.ScheduleRooms)
                   .WithOne(x => x.Schedule)
                   .HasForeignKey(x => x.ScheduleId)
                   .HasConstraintName("FK_ScheduleRooms_Room");


            builder.HasMany(x => x.ScheduleSubjects)
                    .WithOne(x => x.Schedule)
                    .HasForeignKey(x => x.ScheduleId)
                    .HasConstraintName("FK_ScheduleSubjects_Room");
        }
    }
}
