namespace ITI_Blazor_Project
{
    public class ExamQuestion
    {
        public Guid ExamId { get; set; }
        public Exam? Exam { get; set; }
        public Guid QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
