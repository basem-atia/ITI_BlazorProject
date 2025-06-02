namespace ITI_Blazor_Project
{
    public class Exam
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
        public ICollection<ExamQuestion> ExamQuestions { get; set; } = new List<ExamQuestion>();
        public ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();
    }
}
