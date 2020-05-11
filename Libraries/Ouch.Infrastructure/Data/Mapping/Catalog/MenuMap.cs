using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ouch.Core.Domain.Catalog;

namespace Ouch.Infrastructure.Data.Mapping.Catalog
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
