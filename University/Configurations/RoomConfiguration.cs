using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Models;

namespace University.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<RoomConfiguration>
    {
        
        public void Configure(EntityTypeBuilder<RoomConfiguration> builder)
        {
            builder.ToTable("Room", "room");
            builder.Property(x => x.Description)
                .HasMaxLength(200)
                .IsRequired();


            builder.Property(x => x.MaxNumberOfStudents)
                .HasColumnType("int")
                .HasDefaultValue(0)
                  .IsRequired();

            builder.Property(x => x.IsFree)
                .HasDefaultValue(true)
                .IsRequired();


            builder.HasMany(x => x.ScheduleRooms)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId)
                .HasConstraintName("FK_Room_ScheduleRooms");

        }
    }
}
