using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ouch.Core.Domain.Toeic;

namespace Ouch.Infrastructure.Data.Mapping.Toeic
{
    public partial class ToeicQuestionMap : OuchEntityTypeConfiguration<ToeicQuestion>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<ToeicQuestion> builder)
        {
            builder.ToTable(nameof(ToeicQuestion));
            builder.HasKey(question => question.Id);

            builder.Property(question => question.Question).HasMaxLength(400).IsRequired();
            builder.Property(question => question.CorrectAnswer).HasMaxLength(400).IsRequired();

            builder.HasOne(question => question.ToeicTopic)
                .WithMany(topic => topic.ToeicQuestions)
                .HasForeignKey(question => question.ToeicTopicId)
                .IsRequired();

            base.Configure(builder);
        }

        #endregion
    }
}
