namespace University.Models
{
    public class Subject
    {
        public int Id { get; set; }
     
        public int Credit { get; set; }
        public string Name { get; set; }

        public int LowerBound { get; set; }

        public int MaxNumberOfStudents { get; set; }

        public int MaxNumberOfTeachers { get; set; }

        public IEnumerable<Teacher>? Teachers { get; set; }

        public IEnumerable<ScheduleSubject>? ScheduleSubject { get; set; }

        public IEnumerable<StudentSubject>? StudentSubject { get; set; }

    }
}
