using university.Models;

namespace University.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public int? SubjectId { get; set; }
        
        public Subject? Subject { get; set; }

        public int? DepartmentId { get; set; }
      
        public Department? Department { get; set; }

        public int? AddressId { get; set; }
       
        public Address? Address { get; set; }
        public string LastName { get; set; }
       
        public string PersonalId { get; set; }

    }
}
