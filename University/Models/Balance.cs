namespace University.Models
{
    public class Balance
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public int? StudentId { get; set; }
        
        public Student? Student { get; set; }

        public int? SemesterId { get; set; }

        public Semester? Semester { get; set; }

        public decimal? Debth { get; set; }

    }
}
