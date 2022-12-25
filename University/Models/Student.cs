using university.Models;

namespace University.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public int? DepartmentId { get; set; }

        public Department? Department { get; set; }

        public int? AddressId { get; set; }

        public Address? Address { get; set; }

        public int? SemesterId { get; set; }

        public Semester? Semester { get; set; }
        public string LastName { get; set; }

        public string PersonalId { get; set; }
       
        public int StartYear { get; set; }
    
        public IEnumerable<StudentSubject>? StudentSubject { get; set; }
    }
}
