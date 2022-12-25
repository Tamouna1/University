using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Models;
namespace University.Configurations
{
    public class ScheduleRoomConfiguration : IEntityTypeConfiguration<ScheduleRoom>
    {
       
        public void Configure(EntityTypeBuilder<ScheduleRoom> builder)
        {
            builder.ToTable("ScheduleRoom", "schedule_room");

            builder.Property(x => x.ScheduleId);
            builder.Property(x => x.RoomId);



        }
    }
}
