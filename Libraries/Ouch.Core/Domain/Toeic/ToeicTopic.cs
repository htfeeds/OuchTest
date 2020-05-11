using System;
using System.Collections.Generic;

namespace Ouch.Core.Domain.Toeic
{
    public partial class ToeicTopic : BaseEntity
    {
        private ICollection<ToeicQuestion> _toeicQuestions;

        public string Subject { get; set; }

        public bool Deleted { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the collection of ToeicQuestion
        /// </summary>
        public virtual ICollection<ToeicQuestion> ToeicQuestions
        {
            get => _toeicQuestions ?? (_toeicQuestions = new List<ToeicQuestion>());
            protected set => _toeicQuestions = value;
        }
    }
}
