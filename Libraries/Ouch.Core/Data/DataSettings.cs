using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ouch.Core.Data
{
    public partial class DataSettings
    {
        #region Ctor

        public DataSettings()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a data provider
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DataProviderType DataProvider { get; set; }

        /// <summary>
        /// Gets or sets a connection string
        /// </summary>
        public string DataConnectionString { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the information is entered
        /// </summary>
        /// <returns></returns>
        [JsonIgnore]
        public bool IsValid => DataProvider != DataProviderType.Unknown && !string.IsNullOrEmpty(DataConnectionString);

        #endregion
    }
}
