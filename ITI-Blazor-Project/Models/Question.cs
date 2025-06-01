namespace ITI_Blazor_Project
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Text { get; set; } = string.Empty;

        public Answer? Answer { get; set; }
        public Guid CourseId { get; set; }
        public Course? Course { get; set; }
        public ICollection<Choice> Choices { get; set; } = new List<Choice>();
        public ICollection<ExamQuestion> ExamQuestions { get; set; } = new List<ExamQuestion>();
    }
}
