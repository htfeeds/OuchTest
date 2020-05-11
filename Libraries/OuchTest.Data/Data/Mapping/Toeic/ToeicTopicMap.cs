using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OuchTest.Core.Domain.Toeic;
using System;
using System.Collections.Generic;
using System.Text;

namespace OuchTest.Data.Mapping.Toeic
{
    public partial class ToeicTopicMap : OuchEntityTypeConfiguration<ToeicTopic>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<ToeicTopic> builder)
        {
            builder.ToTable(nameof(ToeicTopic));
            builder.HasKey(topic => topic.Id);

            builder.Property(topic => topic.Subject).HasMaxLength(400).IsRequired();

            base.Configure(builder);
        }

        #endregion
    }
}
