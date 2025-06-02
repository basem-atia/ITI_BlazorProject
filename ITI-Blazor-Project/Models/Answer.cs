namespace ITI_Blazor_Project
{
    public class Answer
    {
        public Guid Id { get; set; }
        public Guid? QuestionId { get; set; }
        public Question? Question { get; set; }
        public Guid StudentExamId { get; set; }
        public StudentExam? StudentExam { get; set; }
        public Guid? ChoiceId { get; set; }
        public Choice? Choice { get; set; }
    }
}
