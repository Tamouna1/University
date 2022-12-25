using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Models;

namespace University.Configurations
{
    public class ScheduleSubjectConfiguration : IEntityTypeConfiguration<ScheduleSubject>
    {
        
        public void Configure(EntityTypeBuilder<ScheduleSubject> builder)
        {
            builder.ToTable("ScheduleSubject", "schedule_subject");



            builder.Property(x => x.ScheduleId);
            builder.Property(x => x.SubjectId);



        }
    }
}
