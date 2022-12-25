using University.Models;

namespace University.Models
{
    public class ScheduleRoom
    {

        public int Id { get; set; }

      
        public int? ScheduleId { get; set; }
       
        public Schedule? Schedule { get; set; }

        public int? RoomId { get; set; }


        public Room? Room { get; set; }
    }
}
