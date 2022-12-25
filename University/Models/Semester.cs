namespace University.Models
{
    public class Semester
    {
   
        public int Id { get; set; }
 
        public string Name { get; set; }

        public int AvaliableGPA { get; set; }

        public DateTime? StartDate { get; set; }


        public int? Year { get; set; }

        public DateTime? EndDate { get; set; }

        public IEnumerable<Department>? Departments { get; set; }

        public IEnumerable<Schedule>? Schedules { get; set; }

    
        public IEnumerable<Student>? Students { get; set; }
    }
}
