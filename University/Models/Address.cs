using university.Models; 
namespace university.Models
{
 
    public class Address
    {
        public int Id { get; set; }
       
        public string Address1 { get; set; }
      
        public string? Address2 { get; set; }

        public int? StudentId { get; set; }
        
        public Student? Student { get; set; }
        
        public int? TeacherId { get; set; }
        
        public Teacher? Teacher { get; set; }
    }


}
