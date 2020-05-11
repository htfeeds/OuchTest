using System;

namespace Ouch.Core.Domain.Catalog
{
    public partial class Menu : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Deleted { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }
    }
}
