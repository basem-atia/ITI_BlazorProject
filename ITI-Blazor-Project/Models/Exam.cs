namespace ITI_Blazor_Project
{
    public class Exam
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime? Date { get; set; } = DateTime.Now;
        public TimeSpan Duration { get; set; }
        public Guid InstructorId { get; set; } = Guid.Empty;
        public Instructor Instructor { get; set; } = null!;
        public ICollection<ExamQuestion> ExamQuestions { get; set; } = new List<ExamQuestion>();
        public ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();
    }
}
