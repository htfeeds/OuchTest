using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OuchTest.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OuchTest.Data.Mapping
{
    public partial class OuchEntityTypeConfiguration<TEntity> : IMappingConfiguration, IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        #region Utilities

        /// <summary>
        /// Developers can override this method in custom partial classes in order to add some custom configuration code
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        protected virtual void PostConfigure(EntityTypeBuilder<TEntity> builder)
        {
        }

        #endregion

        #region Methods

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            //add custom configuration
            PostConfigure(builder);
        }

        public virtual void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }

        #endregion
    }
}
