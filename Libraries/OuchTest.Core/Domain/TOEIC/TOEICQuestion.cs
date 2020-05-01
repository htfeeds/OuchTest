namespace OuchTest.Core.Domain.Toeic
{
    public partial class ToeicQuestion : BaseEntity
    {
        public int ToeicTopicId { get; set; }

        public string Question { get; set; }

        public string Answer1 { get; set; }

        public string Answer2 { get; set; }

        public string Answer3 { get; set; }

        public string Answer4 { get; set; }

        public string Answer5 { get; set; }

        public string Answer6 { get; set; }

        public bool IsMultipleAnswer { get; set; }

        public string CorrectAnswer { get; set; }

        public virtual ToeicTopic ToeicTopic { get; set; }
    }
}
