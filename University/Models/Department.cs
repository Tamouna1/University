namespace University.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? SemesterId { get; set; }

        public Semester? Semester { get; set; }

        public int MaxNumberOfStudents { get; set; }

        public int CurrentAmount { get; set; }


        public IEnumerable<Teacher>? Teachers { get; set; }

        public IEnumerable<Student>? Students { get; set; }

    }
}
