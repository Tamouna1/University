using University.Models;
namespace University.Models
{
    public class ScheduleSubject
    {
        public int Id { get; set; }

        public int? ScheduleId { get; set; }
       
        public Schedule? Schedule { get; set; }

        public int? SubjectId { get; set; }

        public Subject? Subject { get; set; }
    }
}
