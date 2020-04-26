namespace OuchTest.Core.Domain.TOEIC
{
    public partial class TOEICQuestion : BaseEntity
    {
        public int TopicId { get; set; }
        public string Content { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public string Answer6 { get; set; }
        public bool IsMultipleAnswer { get; set; }
        public string CorrectAnswerNo { get; set; }
        public virtual TOEICTopic Topic { get; set; }
    }
}
