using System;
using System.Collections.Generic;
using System.Text;

namespace OuchTest.Core.Configuration
{
    /// <summary>
    /// Represents startup Nop configuration parameters
    /// </summary>
    public partial class OuchConfig
    {
        /// <summary>
        /// Gets or sets a value indicating whether to display the full error in production environment.
        /// It's ignored (always enabled) in development environment
        /// </summary>
        public bool DisplayFullErrorStack { get; set; }
    }
}
