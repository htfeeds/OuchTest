using OuchTest.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace OuchTest.Core
{
    public partial class CommonHelper
    {
        #region Properties

        /// <summary>
        /// Gets or sets the default file provider
        /// </summary>
        public static IOuchFileProvider DefaultFileProvider { get; set; }

        #endregion
    }
}
