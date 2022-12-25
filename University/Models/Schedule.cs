using University.Models;
namespace University.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int Year { get; set; }
  

        public TimeSpan StartTime { get; set; }
    
        public int? SemesterId { get; set; }
    
        public Semester? Semester { get; set; }

        public IEnumerable<ScheduleSubject>? ScheduleSubjects { get; set; }
   
        public IEnumerable<ScheduleRoom>? ScheduleRooms { get; set; }

        public TimeSpan EndTime { get; set; }
        
    }
}
