namespace ITI_Blazor_Project
{
    public class Choice
    {
        public Guid Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public bool IsCorrect { get; set; } = false;
        public Guid QuestionId { get; set; }
        public Question? Question { get; set; } 
        public Answer? Answer { get; set; }
    }
}
