namespace ITI_Blazor_Project
{
    public class Instructor
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Decimal Salary { get; set; } 
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }
}
