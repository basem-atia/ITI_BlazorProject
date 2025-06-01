namespace ITI_Blazor_Project
{
    public class StudentExam
    {
        public Guid Id { get; set; }
        public DateTime AssignedAt { get; set; }
        public DateTime SubmittedAt { get; set; }
        public Guid StudentId { get; set; }
        public Student? Student { get; set; }
        public Guid ExamId { get; set; }
        public Exam? Exam { get; set; }
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
