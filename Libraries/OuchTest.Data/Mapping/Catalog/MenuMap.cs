using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OuchTest.Core.Domain.Catalog;
using OuchTest.Core.Domain.Toeic;
using System;
using System.Collections.Generic;
using System.Text;

namespace OuchTest.Data.Mapping.Catalog
{
    public partial class MenuMap : OuchEntityTypeConfiguration<Menu>
    {
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable(nameof(Menu));
            builder.HasKey(menu => menu.Id);

            builder.Property(menu => menu.Name).HasMaxLength(400).IsRequired();

            base.Configure(builder);
        }
    }
}
