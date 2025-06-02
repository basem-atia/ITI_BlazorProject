namespace ITI_Blazor_Project
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Decimal GPA { get; set; }
        public Guid? InstructorId { get; set; }
        public Instructor? Instructor { get; set; } 
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();
    }
}
