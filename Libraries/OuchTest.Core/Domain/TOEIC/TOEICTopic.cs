using System;

namespace OuchTest.Core.Domain.TOEIC
{
    public partial class TOEICTopic : BaseEntity
    {
        public string Subject { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
}
